# dopMiniJogoNET
[![Deploy to CloudFlare Pages](https://github.com/daniloopinheiro/dopMiniJogoNet/actions/workflows/cloudflare_pages_deploy.yml/badge.svg)](https://github.com/daniloopinheiro/dopMiniJogoNet/actions/workflows/cloudflare_pages_deploy.yml)

Jogo interativo de pedra, papel e tesoura desenvolvido em C# .NET com interface colorida no console.  
Um bom exercício para praticar decisões condicionais, loops e programação orientada a objetos em .NET.

## 📑 Índice

1. [Visão Geral](#visão-geral)
2. [Instalação](#instalação)
3. [Como Usar](#como-usar)
4. [Configuração](#configuração)
5. [Contribuições](#contribuições)
6. [Artigos & Conteúdos](#artigos--conteúdos)
7. [Licença](#licença)
8. [Contato](#contato)

---

## Visão Geral

O jogo de pedra, papel e tesoura é um jogo manual no qual cada jogador escolhe um dos três itens. Do ponto de vista da programação, esse desafio é um bom exercício para praticar decisões condicionais, iterações e programação orientada a objetos em C# .NET.

**Funcionalidades principais:**
- Interface colorida no console
- Placar em tempo real
- Validação de entrada do usuário
- Opção de jogar múltiplas rodadas
- Arquitetura limpa com separação de responsabilidades

**Regras do jogo:**
- Pedra vence Tesoura
- Tesoura vence Papel  
- Papel vence Pedra

**Recursos técnicos:**
- .NET 8.0 ou superior
- Console Application
- Programação orientada a objetos
- Enum para opções do jogo
- Tratamento de exceções

---

## Instalação

### Pré-requisitos
- .NET SDK 8.0 ou superior
- IDE: Visual Studio, Visual Studio Code, ou Rider (opcional)

### Verificando a instalação do .NET
```bash
$ dotnet --version
```

### Clonando o repositório
```bash
$ git clone https://github.com/daniloopinheiro/dopMiniJogoNet.git
$ cd dopMiniJogoNet
```

### Restaurando dependências
```bash
$ dotnet restore
```

### Compilando o projeto
```bash
$ dotnet build
```

---

## Como Usar

Execute o projeto diretamente:

```bash
$ dotnet run
```

Ou compile e execute o executável:
```bash
$ dotnet build -c Release
$ dotnet run --configuration Release
```

**Como jogar:**
1. O jogo será iniciado com uma apresentação colorida
2. Digite sua escolha: `1` (Pedra), `2` (Papel) ou `3` (Tesoura)
3. O computador fará sua escolha automaticamente
4. O resultado da rodada será exibido com o placar atual
5. Pressione `S` para continuar ou qualquer outra tecla para sair

**Exemplo de execução:**
```
=========================================
    🎮 PEDRA, PAPEL E TESOURA 🎮
=========================================

Bem-vindo ao jogo Pedra, Papel e Tesoura!
Você jogará contra o computador.

Regras:
🪨 Pedra vence Tesoura
✂️  Tesoura vence Papel
📄 Papel vence Pedra

Escolha sua jogada:
1 - Pedra 🪨
2 - Papel 📄
3 - Tesoura ✂️

Digite sua escolha (1-3): 1
Você escolheu: Pedra 🪨
Computador escolheu: Tesoura ✂️
🎉 Você venceu esta rodada!

Placar: Você 1 x 0 Computador

Deseja jogar novamente? (S/N): s
```

---

## Configuração

O jogo funciona diretamente após a compilação. Não requer configurações adicionais.

**Estrutura do projeto:**
```
dopMiniJogoNet/
├── Program.cs              # Ponto de entrada da aplicação
├── Models/
│   ├── GameOption.cs       # Enum para opções do jogo
│   └── GameResult.cs       # Enum para resultados
├── Services/
│   ├── GameEngine.cs       # Lógica principal do jogo
│   └── DisplayService.cs   # Gerenciamento da interface
├── Utils/
│   └── ConsoleHelper.cs    # Utilitários para console
└── dopMiniJogoNet.csproj    # Arquivo de projeto
```

**Dependências utilizadas:**
- .NET Base Class Library (System.*)
- System.Console para interface
- System.Random para escolhas aleatórias

---

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para:

- Reportar bugs através das Issues
- Sugerir novas funcionalidades
- Enviar Pull Requests com melhorias
- Melhorar a documentação
- Adicionar testes unitários

**Como contribuir:**
1. Fork o projeto
2. Crie uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. Abra um Pull Request

**Padrões de código:**
- Siga as convenções C# (.NET Coding Conventions)
- Use nomes descritivos para variáveis e métodos
- Adicione comentários XML para métodos públicos
- Mantenha a separação de responsabilidades

---

## Artigos & Conteúdos

* 💼 [[LinkedIn](https://www.linkedin.com/in/daniloopinheiro)](https://www.linkedin.com/in/daniloopinheiro)
* ✍️ [[Medium](https://medium.com/@daniloopinheiro)](https://medium.com/@daniloopinheiro)
* 💻 [[Dev.to](https://dev.to/daniloopinheiro)](https://dev.to/daniloopinheiro)

---

## Licença

MIT License © 2025 [[dopme.io](https://dopme.io/)](https://dopme.io) — por [[Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro/)](https://www.linkedin.com/in/daniloopinheiro/)

---

## Contato

### 💬 Suporte Técnico
Para questões técnicas, problemas ou sugestões:
- **Issues**: [[GitHub Issues](https://github.com/daniloopinheiro/dopMiniJogoNet/issues)](https://github.com/daniloopinheiro/dopMiniJogoNet/issues)
- **Discussions**: [[GitHub Discussions](https://github.com/daniloopinheiro/dopMiniJogoNet/discussions)](https://github.com/daniloopinheiro/dopMiniJogoNet/discussions)

### 👨‍💻 Autor
**Danilo O. Pinheiro**  
Especialista em .NET, Clean Architecture e Interoperabilidade em Saúde

- **Email Pessoal**: [[daniloopro@gmail.com](mailto:daniloopro@gmail.com)](mailto:daniloopro@gmail.com)
- **Email Empresarial**: [[devsfree@devsfree.com.br](mailto:devsfree@devsfree.com.br)](mailto:devsfree@devsfree.com.br)
- **Consultoria**: [[contato@dopme.io](mailto:contato@dopme.io)](mailto:contato@dopme.io)
- **LinkedIn**: [[Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro/)](https://www.linkedin.com/in/daniloopinheiro/)

### 🏢 Empresas
- **[[DevsFree](https://devsfree.com.br/)](https://devsfree.com.br)**: Desenvolvimento de Software
- **[[dopme.io](https://dopme.io/)](https://dopme.io)**: Consultoria e Soluções Tecnológicas

---

<div align="center">

**⭐ Se este projeto foi útil, deixe uma estrela no GitHub! ⭐**

<p>
Feito com ❤️ por <strong>Danilo O. Pinheiro</strong><br/>  
<a href="https://devsfree.com.br" target="_blank">DevsFree</a> • <a href="https://dopme.io" target="_blank">dopme.io</a>  
</p>

</div>
