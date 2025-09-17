# OrgManager.WinForms

Aplikácia vo **WinForms (.NET + C#)** pre správu organizačnej štruktúry firiem a evidenciu zamestnancov.  
Dáta sú uložené v **Microsoft SQL Server (Express / LocalDB)** pomocou **Entity Framework Core**.

---

## ✨ Funkcionalita
- Správa 4-úrovňovej hierarchickej štruktúry:
  - Firma → Divízia → Projekt → Oddelenie
- Každý uzol má kód, názov a vedúceho (vedúci = existujúci zamestnanec).
- CRUD operácie (pridať/upraviť/odstrániť) pre:
  - organizačné uzly
  - zamestnancov
- Validácie vstupov (meno, priezvisko, e-mail, telefónne číslo).
- Prehľadná GUI aplikácia vo WinForms:
  - **TreeView**: organizačná štruktúra
  - **DataGridView**: zoznam zamestnancov
  - Ovládacie tlačidlá pre CRUD operácie

---

## 🛠 Použité technológie
- C# / WinForms / .NET 8
- Entity Framework Core (SQL Server provider)
- Microsoft SQL Server Express alebo LocalDB
- Visual Studio 2022

---

## 🚀 Ako spustiť projekt
1. Naklonuj si repozitár:
   ```bash
   git clone https://github.com/martin296223239-crypto/OrgManager.WinForms.git

**## 🚀 Ako spustiť DB**

connection string v AppDbContext.cs:
   // LocalDB (default)
"Server=(localdb)\\MSSQLLocalDB;Database=OrgManagerDb;Trusted_Connection=True;MultipleActiveResultSets=true"

// alebo SQL Express
"Server=.\\SQLEXPRESS;Database=OrgManagerDb;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=true"

Spusti migrácie:

Tools → NuGet Package Manager → Package Manager Console

Update-Database



Cela ukazkova databaza je vo : OrgManagerDbt.sql




📜 Licencia

Projekt je voľne použiteľný na študijné a výukové účely.

