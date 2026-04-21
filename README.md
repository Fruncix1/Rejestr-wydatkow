# 💰 Rejestr Wydatków (C# Windows Forms)

## 📌 Opis projektu

Aplikacja desktopowa napisana w języku **C# (Windows Forms)**, umożliwiająca zarządzanie wydatkami użytkownika.
Pozwala na dodawanie, usuwanie oraz przeglądanie wydatków wraz z automatycznym obliczaniem ich sumy.

Dane zapisywane są w pliku **JSON**, dzięki czemu nie znikają po zamknięciu aplikacji.

---

## 🚀 Funkcjonalności

* ➕ Dodawanie wydatków
* 🗑️ Usuwanie wydatków
* 📊 Wyświetlanie listy wydatków (DataGridView)
* 💰 Automatyczne obliczanie sumy
* 💾 Zapis i odczyt danych z pliku JSON
* 🔄 Automatyczne wczytywanie danych przy uruchomieniu
* 🔍 (opcjonalnie) Wyszukiwanie wydatków

---

## 🖥️ Technologie

* C#
* Windows Forms (.NET Framework / .NET)
* Visual Studio
* JSON (`System.Text.Json`)

---

## 📂 Struktura projektu

```id="ny93tn"
Projekt/
│
├── Form1.cs              # Logika aplikacji
├── Form1.Designer.cs     # UI (automatycznie generowany)
├── Expense.cs            # Model danych
├── FileHelper.cs         # Obsługa zapisu/odczytu JSON
├── expenses.json         # Plik z danymi (tworzony automatycznie)
└── README.md             # Dokumentacja projektu
```

---

## ▶️ Jak uruchomić

1. Otwórz projekt w **Visual Studio**
2. Wykonaj:

   ```
   Build → Rebuild Solution
   ```
3. Uruchom aplikację:

   ```
   F5
   ```

---

## 🎮 Jak korzystać

1. Wpisz kwotę wydatku
2. Wybierz kategorię
3. Ustaw datę
4. (Opcjonalnie) dodaj opis
5. Kliknij **Dodaj**

Aby usunąć wydatek:

* zaznacz go w tabeli
* kliknij **Usuń**

Dane są automatycznie zapisywane do pliku i wczytywane przy ponownym uruchomieniu aplikacji.

---

## 💾 Jak działa zapis danych

* Dane zapisywane są w pliku:

  ```
  bin/Debug/expenses.json
  ```
* Format: JSON
* Zapis następuje:

  * po dodaniu wydatku
  * po usunięciu wydatku

---

## 🧠 Podział pracy (2 osoby)

| Osoba         | Zadanie                           |
| ------------- | --------------------------------- |
| 👨‍💻 Osoba 1 | Interfejs użytkownika (UI)        |
| 👨‍💻 Osoba 2 | Logika aplikacji + zapis do pliku |

---

## 🔧 Możliwe ulepszenia

* 📊 statystyki wydatków
* 📅 filtrowanie po dacie
* ✏️ edycja wydatków
* 🌙 tryb ciemny
* 📤 eksport do CSV (Excel)
* 🔐 walidacja danych

---

## 🎯 Cel projektu

Celem aplikacji jest nauka:

* tworzenia aplikacji okienkowych w C#
* obsługi zdarzeń (eventów)
* pracy z plikami (JSON)
* organizacji kodu (Clean Code)

---

## 👨‍🎓 Autorzy

Projekt wykonany w ramach zajęć szkolnych.
