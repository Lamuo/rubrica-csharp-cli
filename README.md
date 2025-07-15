# Rubrica CLI in C#

Un semplice programma console per gestire una rubrica contatti con funzionalità di caricamento, aggiunta, ricerca, eliminazione, salvataggio e visualizzazione.

## Caratteristiche

- Caricamento iniziale da file CSV
- Aggiunta di nuovi contatti
- Ricerca per nome o cognome (case insensitive)
- Eliminazione di contatti
- Salvataggio su file CSV
- Visualizzazione dei contatti (senza ordinamento)

## Struttura

- `Program.cs`: logica principale e interfaccia CLI
- `Contatto.cs`: definizione della classe Contatto e metodi associati
- `rubrica.csv`: file dati (se presente) con i contatti

## Come usare

1. Clona il repository
2. Apri il progetto in Visual Studio o VS Code
3. Compila ed esegui
4. Segui le istruzioni a schermo per interagire con la rubrica

## Tecnologie usate

- C# (.NET 8.0)
- StreamReader / StreamWriter per gestione file
- Programmazione orientata agli oggetti
- Console CLI interattiva

## Miglioramenti futuri

- Ordinamento automatico dei contatti per cognome
- Validazione degli input (email, telefono)
- Supporto per salvataggio in JSON
- Interfaccia grafica (GUI)
- Integrazione con database o API REST

## Licenza

[MIT License](LICENSE)

---

Made by Alythia 
