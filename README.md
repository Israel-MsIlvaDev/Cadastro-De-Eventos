# 📅 EventManager — Cadastro de Eventos em .NET MAUI

Aplicativo desenvolvido como parte da **Agenda 15 – Programação Mobile I** do Curso Técnico em Desenvolvimento de Sistemas (CETEC / CPS).  
O objetivo da atividade é criar um app mobile com .NET MAUI que permita cadastrar eventos, aplicar cálculos de datas e apresentar um resumo final formatado — utilizando recursos como **BindingContext**, **Models**, **DateTime**, **TimeSpan** e navegação entre páginas.

---

## 🇧🇷 Descrição (Português)

O **EventManager** é um aplicativo simples e funcional para **cadastro de eventos**, utilizando arquitetura básica do .NET MAUI.  
Ele permite que o usuário insira informações essenciais de um evento, e ao finalizar o cadastro, o app exibe um **resumo com todos os dados calculados automaticamente**.

### ✔️ Funcionalidades

- Tela de **cadastro de eventos** contendo:
  - Nome do evento  
  - Data de início  
  - Data de término  
  - Número de participantes  
  - Local do evento  
  - Custo por participante  

- **Cálculo automático** de:
  - Duração do evento em dias  
  - Custo total do evento (participantes × custo × dias)

- Uso de:
  - **BindingContext** para vincular dados à model  
  - **Classe Model (Evento)** contendo propriedades + lógica interna  
  - **DateTime** e **TimeSpan** para manipulação de datas  
  - **StringFormat** para exibição formatada na interface

- Tela de **Resumo do Evento**, mostrando:
  - Todas as informações digitadas  
  - Duração
  - Custo total formatado como moeda  

- Navegação entre telas com **NavigationPage**

---

## 🇬🇧 Description (English)

**EventManager** is a mobile application built with .NET MAUI for registering and summarising event details.  
It allows the user to input basic event information and generates a formatted summary, including calculated duration and total cost.

### ✔️ Features

- **Event registration screen** with:
  - Event name  
  - Start date  
  - End date  
  - Number of participants  
  - Event location  
  - Cost per participant  

- **Automatic calculations**:
  - Event duration (in days)  
  - Total event cost  

- Built using:
  - **BindingContext** linked to the Event model  
  - **Model class** containing properties and calculation logic  
  - **DateTime** and **TimeSpan** for date processing  
  - **StringFormat** for clean UI display  

- **Event Summary Page** displaying:
  - All entered information  
  - Duration  
  - Calculated total cost  

- Navigation handled via **NavigationPage**

---

## 🗂️ Estrutura do Projeto
```
EventosMaui/
│
├── App.xaml
├── App.xaml.cs
├── Models/
│ └── Evento.cs
│
├── Views/
│ ├── CadastroPage.xaml
│ ├── CadastroPage.xaml.cs
│ ├── ResumoPage.xaml
│ └── ResumoPage.xaml.cs
│
├── Resources/
│ ├── Images/
│ └── Styles/
│
└── Platforms/
```


---

## ✨ Tecnologias Utilizadas

- .NET MAUI  
- C#  
- DateTime & TimeSpan  
- NavigationPage  
- BindingContext  
- Visual Studio 2022  

