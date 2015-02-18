	

    SETLOCAL ENABLEEXTENSIONS
     
    :v64_path_a2
    For /F "Tokens=2* skip=2" %%A In ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2" /v "MAIN"') Do (set _ARMA2PATH=%%B)
     
    IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
     
    :v32_path_a2
    For /F "Tokens=2* skip=2" %%C In ('REG QUERY "HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2" /v "MAIN"') Do (set _ARMA2PATH=%%D)
     
    IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELSE (GOTO v64_path_a2oa)
     
    :uac_PATH_A2
    FOR /F "tokens=2* delims=        " %%I IN ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2" /v "MAIN"') DO (SET _ARMA2PATH=%%J)
     
    IF NOT DEFINED _ARMA2PATH (GOTO std_PATH_A2) ELSE (GOTO v64_path_a2oa)
     
    :std_PATH_A2
    FOR /F "tokens=2* delims=        " %%K IN ('REG QUERY "HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2" /v "MAIN"') DO (SET _ARMA2PATH=%%L)
     
    IF NOT DEFINED _ARMA2PATH (GOTO ENDfailA2) ELSE (GOTO v64_path_a2oa)
     
    :v64_path_a2oa
    For /F "Tokens=2* skip=2" %%E In ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA" /v "MAIN"') Do (set _ARMA2OAPATH=%%F)
     
    IF NOT DEFINED _ARMA2OAPATH (GOTO v32_path_a2oa) ELSE (GOTO RUN)
     
    :v32_path_a2oa
    For /F "Tokens=2* skip=2" %%G In ('REG QUERY "HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2 OA" /v "MAIN"') Do set (_ARMA2OAPATH=%%H)
     
    IF NOT DEFINED _ARMA2OAPATH (GOTO uac_PATH_A2OA) ELSE (GOTO RUN)
     
    :uac_PATH_A2OA
    FOR /F "tokens=2* delims=        " %%M IN ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2 OA" /v "MAIN"') DO (SET _ARMA2OAPATH=%%N)
     
    IF NOT DEFINED _ARMA2OAPATH (GOTO std_PATH_A2OA) ELSE (GOTO RUN)
     
    :std_PATH_A2OA
    FOR /F "tokens=2* delims=        " %%O IN ('REG QUERY "HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2 OA" /v "MAIN"') DO (SET _ARMA2OAPATH=%%P)
     
    IF NOT DEFINED _ARMA2OAPATH (GOTO ENDfailA2OA) ELSE (GOTO RUN)
     
    :run
    :v64_path_steam
    For /F "Tokens=2* skip=2" %%Q In ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Valve\Steam" /v "InstallPath"') Do (set _STEAMPATH=%%R)
     
    IF NOT DEFINED _STEAMPATH (GOTO v32_path_steam) ELSE (GOTO runs)
     
    :v32_path_steam
    For /F "Tokens=2* skip=2" %%S In ('REG QUERY "HKLM\SOFTWARE\Valve\Steam" /v "InstallPath"') Do (set _STEAMPATH=%%T)
     
    IF NOT DEFINED _STEAMPATH (GOTO uac_path_steam) ELSE (GOTO runs)
     
    :uac_path_steam
    FOR /F "tokens=2* delims=        " %%U IN ('REG QUERY "HKLM\SOFTWARE\Wow6432Node\Valve\Steam" /v "InstallPath"') DO (SET _STEAMPATH=%%V)
     
    IF NOT DEFINED _STEAMPATH (GOTO std_path_steam) ELSE (GOTO runs)
     
    :std_path_steam
    FOR /F "tokens=2* delims=        " %%W IN ('REG QUERY "HKLM\SOFTWARE\Valve\Steam" /v "InstallPath"') DO (SET _STEAMPATH=%%X)
     
    IF NOT DEFINED _STEAMPATH (GOTO ENDfailSteam) ELSE (GOTO runs)
     
    :runs
     
    "%_ARMA2OAPATH%\ArmA2OA_BE.exe" 0 0 -nosplash -skipintro -noPause -world=empty "-mod=%_ARMA2PATH%;EXPANSION;ca;@DayzOverwatch;@DayZ_Epoch;@DayZ_Epoch1051;" -connect=162.248.95.73 -port=6666 /high
     
    ENDLOCAL
     
    :end
    exit /B 0
     
    :ENDfailA2
    exit /B 1
     
    :ENDfailA2OA
    exit /B 2
     
    :ENDfailSteam
    exit /B 3

