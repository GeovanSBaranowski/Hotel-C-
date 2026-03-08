# 🏨 Sistema de Reserva de Hotel - C#

Projeto simples desenvolvido em **C#** para simular um sistema de reservas de hotel.

O sistema permite cadastrar hóspedes, registrar suítes e calcular o valor da reserva com base no número de dias hospedados.

---

## 📚 Conceitos praticados

Este projeto foi desenvolvido para praticar conceitos fundamentais de **Programação Orientada a Objetos (POO)** em C#:

- Classes e objetos
- Encapsulamento
- Listas
- Métodos
- Validações
- Manipulação de dados
- Cálculos com `decimal`

---

## 🧩 Estrutura do Projeto

O projeto possui três classes principais:

### 👤 Pessoa
Representa um hóspede do hotel.

Propriedades:

- `Nome`
- `Sobrenome`

---

### 🛏️ Suite
Representa uma suíte do hotel.

Propriedades:

- `TipoSuite`
- `Capacidade`
- `ValorDiaria`

---

### 📅 Reserva
Responsável por gerenciar a reserva.

Funções:

- Cadastrar hóspedes
- Cadastrar suíte
- Calcular valor da diária
- Obter quantidade de hóspedes

---

## 💰 Regra de Negócio

Se a reserva tiver **10 dias ou mais**, é aplicado **10% de desconto** no valor total da diária.

---

## ▶️ Como executar o projeto

1. Clone o repositório

```bash
git clone https://github.com/GeovanSBaranowski/Hotel-C-.git

2. Abra o projeto no Visual Studio ou VS Code

3. Execute o projeto

🛠️ Tecnologias utilizadas

C#

.NET

Programação Orientada a Objetos