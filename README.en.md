# TS SE Tool

Maintained fork of **TS SE Tool**, a guarded Windows save editor for **Euro Truck Simulator 2** and **American Truck Simulator**.

> **Current release:** `0.3.12.0`
> **Supported:** Euro Truck Simulator 2 **1.50–1.61**, save formats **61–97** (primary validation on **1.61 / save 97**)
> **American Truck Simulator:** experimental and not validated

[Download](../../releases/latest) · [Report an issue](../../issues/new) · [Português](README.md)

## About

The original project was created by **LIPtoH**. The community continuation by **Fabio** ([ts-se-tool-community](https://github.com/fabiomesquita01/ts-se-tool-community), version 0.3.11.48) adapted the editor to modern ETS2 saves (format 1.50+), which the original 0.3.11.0 release did not understand — and which corrupted saves when writing. This fork inherits that work, preserving all credits and the Apache 2.0 license, and keeps it up to date.

## Main features

- profile, company, money, experience, skills, colors and headquarters;
- garage and visited-city management;
- truck/trailer maintenance and batch operations;
- controlled truck and trailer switching;
- validated Freight and Cargo Market operations;
- convoy position and GPS-route tools without automatic saving;
- verified accessory alternatives;
- safe editing of the six AI-driver skills;
- timestamped backups and separated operation/error/compatibility logs.

## Safety model

Close the game, use a copied manual save, preserve the backup, make one controlled change at a time, reload in the editor and validate in ETS2. Raw graph mutations remain disabled when reference integrity cannot be proven.

## Compatibility

The validated target of this release is **Euro Truck Simulator 2 1.61** with save **format 97**. Save formats 61–96 remain recognized but were not fully homologated. ATS is experimental and unvalidated.

## Credits

Original project by **LIPtoH**. Community continuation (base 0.3.11.48) by **Fabio**. This fork maintained by [ThiagoDantas19](https://github.com/ThiagoDantas19).

Apache License 2.0. Independent project, not affiliated with or endorsed by SCS Software.
