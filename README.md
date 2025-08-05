# LabelMate – Doplňek LibreOffice pro klasifikaci dokumentů

**LabelMate** je jednoduchý doplněk pro LibreOffice, který uživatelům umožňuje snadno klasifikovat dokumenty pomocí volitelných klasifikačních značek (např. TLP). Pomáhá tak zavádět a dodržovat pravidla vnitřní klasifikace dat.

## Funkce
- Flexibilní klasifikační schéma: značení dokumentů podle libovolně definovaných úrovní klasifikace.
- Jednoduché vložení klasifikační značky přímo do záhlaví dokumentu (Writter) nebo do zvolených polí (Calc, Impress).
- Naslouchání události OnSave s výzvou k označení při neklasifikovaném dokumentu.
- Podpora více jazyků (autodetekce jazyka systému, možnost ručního přepnutí).
- Deployment pomocí PowerShell a OXT souboru. 

## Instalace
1. Celou souborovou strukturu archivujte do souboru labelmate.oxt
2. Pomocí PowerShell příkazu použijte OXT soubor k nainstalování doplňku z dostupného síťového umístění
   `& "C:\Program Files\LibreOffice\program\unopkg.com" add ".\labelmate.oxt"`

## Aktuální stav prototypu
Tento repozitář obsahuje první funkční verzi doplňku **LabelMate**.

### Omezení prototypu:
- Funguje pouze pro **LibreOffice Writter**
- Základní, neupravené uživatelské rozhraní
- Pouze jedna přednastavená klasifikační značka v češtině bez možnosti výběru dalších:

## Plánovaný rozvoj
Budoucí vývoj se zaměří na rozšíření funkcí, větší integraci a zlepšení UX.

### Funkce k implementaci:
- Přidání možnosti vybrat vhodnou klasifikační značku
- Rozšíření podpory na Calc a Impress
- Automatická detekce jazyka dokumentu a přizpůsobení značek (EN, CZ, SK)
- Možnost manuální volby jazyka klasifikace
- Naslouchání události OnSave s výzvou k označení při neklasifikovaném dokumentu
- Modernizované uživatelské rozhraní
- Tooltipy a odkazy na interní dokumentaci u klasifikačních voleb
- Uživatelská a administrátorská dokumentace

## Struktura souborů
```
|-- LibreOffice/
    |-- Addons.xcu               # definice GUI komponent (menu/tlačítka)
    |-- description.xml          # metadata rozšíření
    |-- license.txt              # text licence
    |-- LabelMateLibrary/
        |-- Module1.xba          # basic makro obsahující klasifikační funkci
        |-- dialog.xlb           # 
        |-- script.xlb           # 
    |-- META-INF/
        |-- manifest.xml         # manifest pro OXT balíček
    |-- icons/
        |-- icon.png             # ikona doplňku
    |-- pkg-desc/
        |-- pkg-description.en   # popis balíčku v angličtině
|-- labelmate.oxt                # OXT soubor pro deployment přes PowerShell
|-- archive/                     # adresář obsahující testovací soubory s DLL verzí rozšíření
```

## Dokumentace
[LibreOffice HelloWorld Extension](https://wiki.documentfoundation.org/Development/Create_a_Hello_World_LibreOffice_extension)
[Extension Development](https://wiki.documentfoundation.org/Development/Extension_Development)
