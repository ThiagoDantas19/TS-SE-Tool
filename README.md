# TS SE Tool

[![Compilação](https://github.com/ThiagoDantas19/TS-SE-Tool/actions/workflows/build.yml/badge.svg)](https://github.com/ThiagoDantas19/TS-SE-Tool/actions/workflows/build.yml)
[![Licença](https://img.shields.io/badge/licença-Apache--2.0-blue.svg)](LICENSE)
[![ETS2](https://img.shields.io/badge/ETS2-1.61%20%7C%20save%2097-4caf50.svg)](docs/COMPATIBILITY.md)
[![ATS](https://img.shields.io/badge/ATS-experimental%20%2F%20não%20validado-orange.svg)](docs/COMPATIBILITY.md)

Fork mantido do **TS SE Tool**, editor de saves para Windows do **Euro Truck Simulator 2** e **American Truck Simulator**.

> **Versão atual:** `0.3.12.0`
> **Suporte:** Euro Truck Simulator 2 **1.50–1.61**, saves de **formato 61–97** (validação principal no **1.61 / save 97**)
> **American Truck Simulator:** experimental e não validado nesta versão

[Download](../../releases/latest) · [Relatar problema](../../issues/new) · [Documentação](docs/) · [English](README.en.md)

## Sobre o projeto

O projeto original foi criado por **LIPtoH**. A continuação comunitária de **Fabio** ([ts-se-tool-community](https://github.com/fabiomesquita01/ts-se-tool-community), versão 0.3.11.48) adaptou o editor para os saves modernos do ETS2 (formato 1.50+), que a versão 0.3.11.0 original não conhecia — e que corrompia saves ao gravar. Este fork herda esse trabalho, preservando os créditos e a licença Apache 2.0, e o mantém atualizado.

A prioridade é a **integridade do save**: alterações são preparadas, validadas e gravadas de forma cirúrgica. Recursos que exigem mutação estrutural ainda não comprovada permanecem bloqueados.

## Recursos principais

- edição de perfil, empresa, dinheiro, experiência, habilidades, cores e sede;
- gerenciamento de garagens e cidades visitadas;
- manutenção individual e em lote de caminhões e reboques;
- placa, combustível, odômetro e carga do reboque;
- troca controlada de caminhões e reboques em topologias validadas;
- Freight Market e Cargo Market com validação semântica;
- ferramentas de comboio para posição e rota GPS sem salvamento automático;
- editor de acessórios com alternativas verificadas;
- edição segura das seis habilidades dos motoristas IA;
- backups com data e hora antes da gravação;
- logs separados para operação, erros reais e compatibilidade.

## Segurança

1. Feche o jogo antes de editar.
2. Trabalhe em uma cópia de um save manual.
3. Preserve o backup criado pelo programa.
4. Faça uma alteração controlada por vez.
5. Recarregue o save no editor e depois valide no jogo.

O writer moderno preserva IDs, referências, ordem e quantidade das listas. Operações que não podem ser provadas com segurança são recusadas.

## Recursos intencionalmente bloqueados

- contratar ou demitir motoristas IA;
- editor bruto do grafo de caminhões e reboques;
- colagem completa de veículos;
- inserção, exclusão ou reordenação de blocos de acessórios;
- caminhos manuais de peças no modo Gamer;
- promessa de compatibilidade universal com DLCs e mods.

## Compatibilidade

O alvo validado desta release é o **Euro Truck Simulator 2 1.61**, usando save de **formato 97**. Os formatos 61–96 continuam reconhecidos pela camada de compatibilidade, mas não foram integralmente homologados.

O ATS não foi testado e não faz parte do aceite desta versão.

## Download

Use somente a seção [Releases](https://github.com/ThiagoDantas19/TS-SE-Tool/releases/latest). Verifique `SHA256SUMS.txt` antes de executar. O atualizador interno usa o asset estável `TS.SE.Tool.latest.zip`, publicado na release mais recente e validado por SHA-512.

## Compilação

Requisitos: Windows, Visual Studio/Build Tools 2022, .NET Framework 4.7.2 Targeting Pack e NuGet.

```powershell
nuget restore "TS SE Tool.sln"
msbuild "TS SE Tool.sln" /t:Rebuild /p:Configuration=Release /p:Platform="Any CPU"
```

## Logs

- `log.log`: operações, preparação e validações;
- `errorlog.log`: erros reais e exceções;
- `compatibility.log`: campos novos ou desconhecidos preservados pela camada de compatibilidade.

Não publique saves sem remover dados pessoais do perfil.

## Créditos

- **Projeto e autor original:** LIPtoH — <https://github.com/LIPtoH/TS-SE-Tool>
- **Continuação comunitária (base 0.3.11.48):** Fabio — <https://github.com/fabiomesquita01/ts-se-tool-community>
- **Manutenção deste fork:** [ThiagoDantas19](https://github.com/ThiagoDantas19)

## Licença e aviso

Licenciado sob a **Apache License 2.0**, com créditos e avisos originais preservados. Consulte [LICENSE](LICENSE) e [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md).

Projeto independente, sem vínculo, patrocínio ou endosso da SCS Software. Edição incorreta ou uso após uma atualização incompatível pode corromper o progresso. Use por sua conta e risco e mantenha backups.
