# SafeVault Capstone Project

## ✅ Identifizierte Sicherheitsprobleme
- SQL Injection durch direkte Benutzereingabe
- Keine Passwort-Hashing-Strategie
- Kein Rollenmanagement

## 🔐 Umgesetzte Sicherheitsmaßnahmen
- Eingabevalidierung mit Parametrisierten Queries
- Passwörter werden mit SHA-256 gehasht
- Rollenkontrolle für Admin/Benutzer

## 🤖 Unterstützung durch GitHub Copilot
- Copilot schlug sicheren SQL-Code mit `SqlParameter` vor
- Hilfe beim Erstellen von `AuthenticateUser` und Tests
- Automatisch generierter Testcode für gängige Angriffsvektoren

## 🧪 Tests
- Sicherheits-Unit-Tests mit xUnit
- Tests für gültige und ungültige Logins
