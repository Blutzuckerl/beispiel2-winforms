# Beispiel2 WinForms

## Overview
Windows Forms learning project with simple math training flows.
The app generates random numbers and validates user-entered multiplication/division results.

## Main Features
- Random number generation (`1..200`)
- Multiplication result check with user feedback
- Division result check with validation (including divide-by-zero guard)
- Message box feedback for correct/incorrect answers

## Tech Stack
- C#
- .NET Framework 4.7.2
- Windows Forms

## Project Structure
- `Program.cs`: startup entry
- `Form1.cs`: core quiz/validation logic
- `Form1.Designer.cs`: form layout and controls
- `Beispiel2.sln`: main Visual Studio solution
- `Beispiel2 (2).sln` / `Form1 (2).cs`: older duplicate snapshots

## Requirements
- Windows
- Visual Studio with .NET desktop development

## Run Locally
1. Open `Beispiel2.sln` in Visual Studio.
2. Restore packages if prompted.
3. Start with `F5`.

## Security and Data Hygiene
- Do not commit build output (`bin`, `obj`) or IDE state.
- Keep secrets, certs, and local DB artifacts outside git.
