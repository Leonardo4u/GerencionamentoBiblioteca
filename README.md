# 📚 Sistema de Gerenciamento de Biblioteca

Projeto desenvolvido para a disciplina de **Introdução à Programação Orientada a Objetos** do curso de **Análise e Desenvolvimento de Sistemas** da Universidade Anhembi Morumbi.

## 🧠 Objetivo

O sistema tem como objetivo aplicar os principais conceitos de **Programação Orientada a Objetos (POO)** na prática, como:

- Encapsulamento  
- Herança  
- Polimorfismo  
- Composição  
- Uso de coleções (`List<T>`)

---

## ⚙️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Plataforma:** .NET Framework  
- **Interface:** Console (linha de comando)  
- **IDE:** Visual Studio

---

## 🧩 Funcionalidades

- Cadastro de livros  
- Cadastro de usuários (alunos e professores)  
- Realização de empréstimos  
- Registro de devoluções  
- Relatórios:
  - Livros disponíveis
  - Usuários cadastrados
  - Empréstimos realizados
  - Livros emprestados

---

## 🏗️ Estrutura de Classes

- `Usuario` (classe abstrata)  
- `Aluno` e `Professor` (herdam de `Usuario`)  
- `Livro`  
- `Emprestimo`  
- `Biblioteca` (classe que gerencia todo o sistema)  
- `Program` (classe principal com o menu de execução)

---

## ▶️ Como Executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
