//-----------------------------------------------------------------------
// Copyright 2016 Sitecore Corporation A/S
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file 
// except in compliance with the License. You may obtain a copy of the License at
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the 
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
// either express or implied. See the License for the specific language governing permissions 
// and limitations under the License.
// -------------------------------------------------------------------------------------------

Number.prototype.formatMoney = function (c, d, t) {
  var n = this,
      c = isNaN(c = Math.abs(c)) ? 2 : c,
      d = d == undefined ? "." : d,
      t = t == undefined ? "," : t,
      s = n < 0 ? "-" : "",
      i = String(parseInt(n = Math.abs(Number(n) || 0).toFixed(c))),
      j = (j = i.length) > 3 ? j % 3 : 0;
  return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};

$(document).ready(function () {
    $(".product-image-container .thumbnails .thumbnail").on('click', function (e) {
        e.preventDefault();

        $('.product-image-container .prod-large-view').attr('src', $(this).attr('href'));
    });
});

//-----------------------------------------------------------------//
//          PRICE INFO                                             //
//-----------------------------------------------------------------//

priceInfoVM = new PriceInfoViewModel();

function initProductPriceInfo(sectionId) {
    ko.applyBindingsWithValidation(priceInfoVM, document.getElementById(sectionId));
}

function switchProductPriceInfo(listPriceText, adjustedPriceText, isOnSale, savingsText) {
    priceInfoVM.switchInfo(listPriceText, adjustedPriceText, isOnSale, savingsText);
}

//-----------------------------------------------------------------//
//          VARIANTS                                               //
//-----------------------------------------------------------------//

var VariantInfoModel = function (variantId, size, color, priceBefore, priceNow, isOnSale, savingsMessage) {
    var self = this;

    self.variantId = variantId;
    self.size = size;
    self.color = color;
    self.priceNow = priceNow;
    self.priceBefore = priceBefore;
    self.isOnSale = isOnSale;
    self.savingsMessage = savingsMessage;
}

function AddVariantCombination(size, productColor, id, listPrice, adjustedPrice, isOnSale, savingsMessage) {
    if (!window.variantCombinationsArray) {
        window.variantCombinationsArray = new Array();
    }

    window.variantCombinationsArray[size + '_' + productColor] = new VariantInfoModel(id, size, productColor, listPrice, adjustedPrice, isOnSale, savingsMessage);
}

function AddVariantKitCombination(name, size, productColor, id, listPrice, adjustedPrice, isOnSale, savingsMessage) {
  if (!window.kitCombinationsArray) {
    window.kitCombinationsArray = new Array();
  }

  if (window.kitCombinationsArray[name] == null)
  {
    window.kitCombinationsArray[name] = new Array();
  }
      
    var kit = window.kitCombinationsArray[name];
    kit[size + '_' + productColor] = new VariantInfoModel(id, size, productColor, listPrice, adjustedPrice, isOnSale, savingsMessage);
    window.kitCombinationsArray[name] = kit;
}

function VariantSelectionChanged() {
    var size = '';
    var color = '';

    if ($('#variantSize').length) {
        size = $('#variantSize').val();
    }

    if ($('#variantColor').length || $('#variantColor').length == 1) {
        color = $('#variantColor').val();
    }

    ClearGlobalMessages();
    $('#AddToCartButton').removeAttr('disabled');
    var variantInfo = GetVariantIdByCombination(size, color);
    if (variantInfo == -1) {
        var data = [];
        data.Success = false;
        data.Errors = [$("#InvalidVariant").text()];
        ShowGlobalMessages(data);
        $('#AddToCartButton').attr('disabled', 'disabled');
    } else {
        $('#VariantId').val(variantInfo.variantId);
        if (stockInfoVM) {
            stockInfoVM.switchInfo();
        }
        switchProductPriceInfo(variantInfo.priceBefore.toLocaleString(), variantInfo.priceNow.toLocaleString(), variantInfo.isOnSale, variantInfo.savingsMessage);
    }
}

function VariantKitSelectionChanged() {

  var size = '';
  var color = '';
  

  if ($('#variantSize').length) {
    size = $('#variantSize').val();
  }

  if ($('#variantColor').length || $('#variantColor').length == 1) {
    color = $('#variantColor').val();
  }

  ClearGlobalMessages();
  $('#AddToCartButton').removeAttr('disabled');
  var variantInfo = GetVariantIdByCombination(size, color);
  if (variantInfo == -1) {
    var data = [];
    data.Success = false;
    data.Errors = [$("#InvalidVariant").text()];
    ShowGlobalMessages(data);
    $('#AddToCartButton').attr('disabled', 'disabled');
  } else {
    $('#VariantId').val(variantInfo.variantId);
    if (stockInfoVM) {
      //stockInfoVM.switchInfo();
    }
    //switchProductPriceInfo(variantInfo.priceBefore.toLocaleString(), variantInfo.priceNow.toLocaleString(), variantInfo.isOnSale, variantInfo.savingsMessage);
  }

  var kitCount = $('#KitCount').val();
  var qty = $('#Quantity').val();
  var priceNow = Number(variantInfo.priceNow.replace(/[^0-9\.-]+/g, ""));

  for (i=0; i < kitCount; i++)
  {
    var kitSelect = '[' + i + '].Variant_Color';
    var kitQuantity = '[' + i + '].Quantity';
    var kitVariantId = '[' + i + '].VariantId';
    var kit = window.kitCombinationsArray[kitSelect];
    var quantity = $('input[name="' + kitQuantity + '"]').val();
    //alert($('select[name="' + kitSelect + '"]').val());
    var selectedVariantKit = kit["_" + $('select[name="' + kitSelect + '"]').val()];
    var currency = selectedVariantKit.priceNow;
    var number = Number(currency.replace(/[^0-9\.-]+/g, ""));
    priceNow += (number * quantity) * qty;
    $('input[name="' + kitVariantId + '"]').val(selectedVariantKit.variantId);
    switchProductPriceInfo(priceNow.formatMoney(2, '.', ','), priceNow.formatMoney(2, '.', ','), 0, "");
  }
}

function GetVariantIdByCombination(size, productColor) {
    if (!window.variantCombinationsArray || !window.variantCombinationsArray[size + '_' + productColor]) {
        return -1;
    }

    return window.variantCombinationsArray[size + '_' + productColor];
}

function CheckGiftCardBalance() {
    var giftCardId = $("#GiftCardId").val();
    $("#balance-value").html('');
    if (giftCardId.length === 0) {
        return;
    }

    $('#CheckGiftCardBalanceButton').button('loading');
    var data = {};
    data.GiftCardId = giftCardId;
    ClearGlobalMessages();
    AJAXPost("/api/storefront/catalog/checkgiftcardbalance", JSON.stringify(data), function (data, success, sender) {
        if (success && data.Success) {
            $("#balance-value").html(data.FormattedBalance);
        }

        $('#CheckGiftCardBalanceButton').button('reset');
        ShowGlobalMessages(data);
    }, this);
}

//-----------------------------------------------------------------//
//          SIGN UP FOR NOTIFICATION AND STOCK INFO                //
//-----------------------------------------------------------------//
var stockInfoVM = null;

$(function() {
    signForNotificationVM = {
        fullName: ko.validatedObservable().extend({ required: true }),
        email: ko.validatedObservable().extend({ required: true, email: true }),
        messages: ko.observable(new ErrorSummaryViewModel('signForNotificationModalMessages')),

        load: function() {
            this.messages().ClearMessages();
            AJAXPost("/api/storefront/customers/getcurrentuser", null, function(data, success, sender) {
                if (success && data && data.Success) {
                    if (data.FullName && data.FullName.length > 0) {
                        signForNotificationVM.fullName(data.FullName);
                    }

                    if (data.Email && data.Email.length > 0) {
                        signForNotificationVM.email(data.Email);
                        signForNotificationVM.confirmEmail(data.Email);
                    }
                }

                signForNotificationVM.messages().AddToErrorList(data);
            });
        },

        signUp: function() {
            this.messages().ClearMessages();
            if (this.errors().length === 0) {
                $('#signForNotificationButton').button('loading');
                var data = {
                    "ProductId": stockInfoVM.selectedStockInfo().productId(),
                    "CatalogName":  $("#product-catalog").val(),
                    "FullName": this.fullName(),
                    "Email": this.email(),
                    "VariantId": stockInfoVM.selectedStockInfo().variantId()
                };

                AJAXPost('/api/storefront/Catalog/signupforbackinstocknotification', JSON.stringify(data), function(data, success, sender) {
                    if (data.Success && success) {
                        // CLEANING MODEL 

                        $('#signForNotificationModal').modal('hide');
                    }

                    $('#signForNotificationButton').button('reset');
                    signForNotificationVM.messages().AddToErrorList(data);
                }, this);
            } else {
                this.errors.showAllMessages();
            }
        },

        close: function() {
            this.messages().ClearMessages();
            $('#signForNotificationModal').modal('hide');
        }
    };
    signForNotificationVM.confirmEmail = ko.validatedObservable().extend({
        validation: {
            validator: function(val, other) { return val === other; },
            message: 'Emails do not match.',
            params: signForNotificationVM.email
        }
    });


    signForNotificationVM.errors = ko.validation.group(signForNotificationVM);

    signForNotificationVM.signUpEnable = ko.computed(function() {
        return signForNotificationVM.errors().length === 0;
    });

    if ($('#signForNotificationModal').length > 0) {
        signForNotificationVM.load();
        ko.validation.registerExtenders();
        ko.applyBindingsWithValidation(signForNotificationVM, document.getElementById('signForNotificationModal'));
    }

    if ($('#stock-info').length > 0) {
        stockInfoVM = new StockInfoListViewModel();
        stockInfoVM.load();
        ko.applyBindingsWithValidation(stockInfoVM, document.getElementById('stock-info'));
    }

    if ($('#GiftCardId').length > 0) {
        $('#GiftCardId').keyup(function () {
            $("#balance-value").html('');
            if ($(this).val().trim().length > 0) {
                $('#CheckGiftCardBalanceButton').removeAttr('disabled');
            } else {
                $('#CheckGiftCardBalanceButton').attr('disabled', 'disabled');
            }
        });
    }
});

//-----------------------------------------------------------------//
//          ADD TO CART                                            //
//-----------------------------------------------------------------//

function AddToCartSuccess(data) {
    if (data.Success) {
        $("#addToCartSuccess").show().fadeOut(4000);
        UpdateMiniCart();
    }

    ShowGlobalMessages(data);
    // Update Button State
    $('#AddToCartButton').button('reset');
}

function AddToCartFailure(data) {
    ShowGlobalMessages(data);
    // Update Button State
    $('#AddToCartButton').button('reset');
}

function SetAddButton() {
    $(document).ready(function () {
        ClearGlobalMessages();
        $("#AddToCartButton").button('loading');
    });
}