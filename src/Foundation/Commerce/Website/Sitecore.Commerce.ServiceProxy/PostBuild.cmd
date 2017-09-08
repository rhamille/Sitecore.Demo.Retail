@Echo OFF
SETLOCAL
set CPrefix=%~d0%~p0

if '%TF_BUILD%' == 'True' (
  pushd %CPrefix%
  call powershell.exe -ExecutionPolicy Unrestricted -NOPROFILE -FILE %BUILD_REPOSITORY_LOCALPATH%\CommerceEngine\build\SignSingle.ps1 -FileToSign %1
  popd
)
ENDLOCAL
