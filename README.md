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

## Vulnerabilities Fixed
- SQL Injection: prevented by using parameterized queries.
- Weak authentication: added role-based login for Admin/User.

## Tests
- xUnit tests simulate SQL injection attacks and test login success/failure.

## Copilot Contribution
Copilot suggested parameter usage, helped build authentication logic and test scaffolds.