# ✅ Resumo das Mudanças na Classe `Reserva`

Este documento lista todas as alterações realizadas na classe `Reserva` durante a implementação do projeto de hospedagem.

---

## 📂 Estrutura e Organização

- [x] Atualizado o namespace para a sintaxe moderna:
  - De: `namespace DesafioProjetoHospedagem.Models {`
  - Para: `namespace DesafioProjetoHospedagem.Models;`

---

## 🧱 Construtores

- [x] Mantido o construtor padrão `public Reserva()`.
- [x] Adicionado construtor com parâmetro:
  ```csharp
  public Reserva(int diasReservados)
  {
      DiasReservados = diasReservados;
  }
