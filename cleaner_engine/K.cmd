@ECHO OFF
CD..
K:
Echo Iniciando a limpeza da unidade...
attrib -s -h -a -r /S /D *.*
del *.lnk /S
del *.vbs /S
del *.inf /S
pause >nul | Echo.Finalizado a limpeza e recuperacao dos arquivos da unidade K:, pressione qualquer tecla para sair.