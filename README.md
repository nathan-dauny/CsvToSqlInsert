# 🧩 CsvToSqlInsert

**CsvToSqlInsert** is a C# library that allows you to convert a typed in-memory CSV representation into valid `INSERT INTO` SQL statements.  
It's designed to integrate seamlessly with [`CsvToDynamicObject`](https://github.com/nathan-dauny/CsvToDynamicObject) and any system that needs to bulk-generate SQL from tabular data.

---

## 🚀 Features

- 🧱 Convert any typed CSV object into SQL `INSERT` statements  
- 🔍 Leverages column type detection to format values correctly (quotes, NULLs, booleans, etc.)  
- 🔁 Streaming-based generation using `IEnumerable<string>` (no memory overhead)  
- 🔌 Follows SOLID principles with extensible architecture  
- 🛠️ Easy to integrate into any .NET project or pipeline  
- ✨ Designed to support future SQL generation (UPDATE, DELETE...)

---

## 🛠️ Tech Stack

- .NET 9 (C#)  
- Modular and testable architecture:
  - `CsvToSqlInsert` : main logic and interface  
  - `SqlInsertStatementBuilder` : default builder for `INSERT` statements  
- No external dependencies — lightweight and clean  

---

## 📦 Compatible With

- ✅ `CsvToDynamicObjectLib`  
- ✅ Any `List<Dictionary<string, object>>` or structured CSV-like input  

---

## ⚙️ Getting Started

### Clone and build

```bash
git clone https://github.com/nathan-dauny/CsvToSqlInsert.git
cd CsvToSqlInsert
dotnet build
