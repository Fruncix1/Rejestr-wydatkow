# 💰 Rejestr Wydatków (C# Windows Forms)

## 📌 Opis projektu

Aplikacja desktopowa napisana w języku **C# (Windows Forms)**, umożliwiająca zarządzanie wydatkami użytkownika.
Pozwala na dodawanie, usuwanie oraz przeglądanie wydatków wraz z automatycznym obliczaniem ich sumy.

Projekt został wykonany jako aplikacja edukacyjna, bez użycia bazy danych – dane przechowywane są w pamięci (opcjonalnie w pliku JSON).

---

## 🚀 Funkcjonalności

* ➕ Dodawanie wydatków
* 🗑️ Usuwanie wydatków
* 📊 Wyświetlanie listy wydatków (DataGridView)
* 💰 Automatyczne obliczanie sumy
* 🔍 (opcjonalnie) Wyszukiwanie wydatków
* 💾 (opcjonalnie) Zapis i odczyt z pliku JSON

---

## 🖥️ Technologie

* C#
* Windows Forms (.NET Framework / .NET)
* Visual Studio

---

## 📂 Struktura projektu

```
Projekt/
│
├── Form1.cs              # Logika aplikacji
├── Form1.Designer.cs     # UI (automatycznie generowany)
├── Expense.cs            # Model danych
├── FileHelper.cs         # Obsługa zapisu/odczytu (opcjonalnie)
└── README.md             # Dokumentacja projektu
```

---

## ▶️ Jak uruchomić

1. Otwórz projekt w **Visual Studio**
2. Kliknij:

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

---

## 🧠 Podział pracy (2 osoby)

| Osoba         | Zadanie                    |
| ------------- | -------------------------- |
| 👨‍💻 Osoba 1 | Interfejs użytkownika (UI) |
| 👨‍💻 Osoba 2 | Logika aplikacji           |

---

## 🔧 Możliwe ulepszenia

* 💾 zapis do pliku JSON
* 📊 statystyki wydatków
* 🔍 filtrowanie i wyszukiwanie
* 🌙 tryb ciemny
* ✏️ edycja wydatków

---

## 🎯 Cel projektu

Celem aplikacji jest nauka:

* tworzenia aplikacji okienkowych w C#
* pracy z kontrolkami Windows Forms
* organizacji kodu (Clean Code)
* obsługi zdarzeń (eventów)

---

## 👨‍🎓 Autorzy

Projekt wykonany przez Franka Mioduszewskiego i Grzegorza Kopanię.
