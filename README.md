# Trabalho de Conclusão de Curso - Middleware OPCUA

A presente proposta tem como objetivo facilitar o acesso dos dados do parque fabril de empresas que optarem pela tecnologia OPC UA como canal de comunicação.

Esta facilidade vem de encontro com a grande procura pela automação, trazendo de forma simples e com dados já compilados dos recursos que trarão benefícios durante a implementação e para a configuração de novos recursos.

Neste sentido, com um middleware de comunicação, todos os sistemas não necessitarão da implementação individual de todas as camadas do protocolo OPC, podendo utilizar este middleware para implementações mais simples e somente dos métodos necessários para a consumo dos dados.

## Arquitetura e Design Patterns

### Clean Architecture

### Design Patterns

#### S.O.L.I.D

#### Mediator

#### CQRS


---
Criar arquivo ```.git/hooks/pre-commit``` para a formatação baseada no .editorconfig

```bash
#!/bin/sh
LC_ALL=C
# Select files to format
FILES=$(git diff --cached --name-only --diff-filter=ACM "*.cs" | sed 's| |\\ |g')
[ -z "$FILES" ] && exit 0

# Format all selected files
echo "$FILES" | cat | xargs | sed -e 's/ /,/g' | xargs dotnet format --include

# Add back the modified files to staging
echo "$FILES" | xargs git add

exit 0
```