# Testes da 0.3.12.0

1. Confirmar build Release/Any CPU com zero erros.
2. Abrir `TS SE Tool.exe` e confirmar versão `0.3.12.0`.
3. Abrir a tela Sobre e confirmar `ETS2 1.61 / save 97` e ATS experimental.
4. Confirmar no log o marcador `0.3.12.0 release initialized`.
5. Carregar uma cópia de save ETS2 1.61 no formato 97 sem salvar.
6. Executar uma alteração isolada, salvar uma única vez e recarregar.
7. Abrir o save no ETS2 e validar o resultado.
8. Confirmar que `errorlog.log` contém somente erros reais e que diagnósticos ficam em `compatibility.log`.
9. Testar **Check for updates**; o download deve usar `TS.SE.Tool.latest.zip` e passar na validação SHA-512.
10. Confirmar que os recursos bloqueados por segurança permanecem indisponíveis.
