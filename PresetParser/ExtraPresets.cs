﻿using System;
using System.Collections.Generic;
using PresetParser.Models;

namespace PresetParser
{
    public static class ExtraPresets
    {
        public static IEnumerable<ExtraPreset> GetExtraPresets(string annoVersion)
        {
            var result = new List<ExtraPreset>();

            switch (annoVersion)
            {
                case Constants.ANNO_VERSION_1404:
                    result.AddRange(GetExtraPresetsForAnno1404());
                    break;
                case Constants.ANNO_VERSION_2070:
                    result.AddRange(GetExtraPresetsForAnno2070());
                    break;
                case Constants.ANNO_VERSION_1800:
                    result.AddRange(GetExtraPresetsForAnno1800());
                    break;
            }

            return result;
        }

        public static IEnumerable<ExtraRoads> GetExtraRoads()
        {
            var result = new List<ExtraRoads>();
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 3, Borderless = true, Road = true, Faction = "Roads (x3)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x3", Template = "Road", LocaEng = "Road 1x 3", LocaGer = "Straßen 1x 3", LocaFra = "Route 1x 3", LocaPol = "Drogowa 1x 3", LocaRus = "Дорога 1x 3" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 6, Borderless = true, Road = true, Faction = "Roads (x3)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x6", Template = "Road", LocaEng = "Road 1x 6", LocaGer = "Straßen 1x 6", LocaFra = "Route 1x 6", LocaPol = "Drogowa 1x 6", LocaRus = "Дорога 1x 6" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 9, Borderless = true, Road = true, Faction = "Roads (x3)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x9", Template = "Road", LocaEng = "Road 1x 9", LocaGer = "Straßen 1x 9", LocaFra = "Route 1x 9", LocaPol = "Drogowa 1x 9", LocaRus = "Дорога 1x 9" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 4, Borderless = true, Road = true, Faction = "Roads (x4)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x4", Template = "Road", LocaEng = "Road 1x 4", LocaGer = "Straßen 1x 4", LocaFra = "Route 1x 4", LocaPol = "Drogowa 1x 4", LocaRus = "Дорога 1x 4" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 8, Borderless = true, Road = true, Faction = "Roads (x4)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x8", Template = "Road", LocaEng = "Road 1x 8", LocaGer = "Straßen 1x 8", LocaFra = "Route 1x 8", LocaPol = "Drogowa 1x 8", LocaRus = "Дорога 1x 8" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 12, Borderless = true, Road = true, Faction = "Roads (x4)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x12", Template = "Road", LocaEng = "Road 1x12", LocaGer = "Straßen 1x12", LocaFra = "Route 1x12", LocaPol = "Drogowa 1x12", LocaRus = "Дорога 1x12" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 16, Borderless = true, Road = true, Faction = "Roads (x4)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x16", Template = "Road", LocaEng = "Road 1x16", LocaGer = "Straßen 1x16", LocaFra = "Route 1x16", LocaPol = "Drogowa 1x16", LocaRus = "Дорога 1x16" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 5, Borderless = true, Road = true, Faction = "Roads (x5)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x5", Template = "Road", LocaEng = "Road 1x 5", LocaGer = "Straßen 1x 5", LocaFra = "Route 1x 5", LocaPol = "Drogowa 1x 5", LocaRus = "Дорога 1x 5" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 10, Borderless = true, Road = true, Faction = "Roads (x5)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x10", Template = "Road", LocaEng = "Road 1x10", LocaGer = "Straßen 1x10", LocaFra = "Route 1x10", LocaPol = "Drogowa 1x10", LocaRus = "Дорога 1x10" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 15, Borderless = true, Road = true, Faction = "Roads (x5)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x15", Template = "Road", LocaEng = "Road 1x15", LocaGer = "Straßen 1x15", LocaFra = "Route 1x15", LocaPol = "Drogowa 1x15", LocaRus = "Дорога 1x15" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 20, Borderless = true, Road = true, Faction = "Roads (x5)", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x20", Template = "Road", LocaEng = "Road 1x20", LocaGer = "Straßen 1x20", LocaFra = "Route 1x20", LocaPol = "Drogowa 1x20", LocaRus = "Дорога 1x20" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 7, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x7", Template = "Road", LocaEng = "Road 1x 7", LocaGer = "Straßen 1x 7", LocaFra = "Route 1x 7", LocaPol = "Drogowa 1x 7", LocaRus = "Дорога 1x 7" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 11, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x11", Template = "Road", LocaEng = "Road 1x11", LocaGer = "Straßen 1x11", LocaFra = "Route 1x11", LocaPol = "Drogowa 1x11", LocaRus = "Дорога 1x11" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 13, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x13", Template = "Road", LocaEng = "Road 1x13", LocaGer = "Straßen 1x13", LocaFra = "Route 1x13", LocaPol = "Drogowa 1x13", LocaRus = "Дорога 1x13" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 14, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x14", Template = "Road", LocaEng = "Road 1x14", LocaGer = "Straßen 1x14", LocaFra = "Route 1x14", LocaPol = "Drogowa 1x14", LocaRus = "Дорога 1x14" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 17, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x17", Template = "Road", LocaEng = "Road 1x17", LocaGer = "Straßen 1x17", LocaFra = "Route 1x17", LocaPol = "Drogowa 1x17", LocaRus = "Дорога 1x17" });
            result.Add(new ExtraRoads { BuildBlockerX = 1, BuildBlockerZ = 19, Borderless = true, Road = true, Faction = "Other Roads", Group = null, Header = "- Road Presets", IconFileName = null, Identifier = "Street_1x19", Template = "Road", LocaEng = "Road 1x19", LocaGer = "Straßen 1x19", LocaFra = "Route 1x19", LocaPol = "Drogowa 1x19", LocaRus = "Дорога 1x19" });
            return result;
        }

        private static IEnumerable<ExtraPreset> GetExtraPresetsForAnno1404()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 2, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_3x2", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(3x2) Farm field", LocaGer = "(3x2) Gemüseäcker", LocaFra = "(3x2) Champ agricole", LocaPol = "(3x2) Pole", LocaRus = "(3x2) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 3, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_3x3", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(3x3) Farm field", LocaGer = "(3x3) Gemüseäcker", LocaFra = "(3x3) Champ agricole", LocaPol = "(3x3) Pole", LocaRus = "(3x3) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 3, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_4x3", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(4x3) Farm field", LocaGer = "(4x3) Gemüseäcker", LocaFra = "(4x3) Champ agricole", LocaPol = "(4x3) Pole", LocaRus = "(4x3) Поле" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 4, Faction = "Production", Group = "Farm Fields", Header = "(A4) Anno 1404", IconFileName = "A4_icon_116_22.png", Identifier = "FarmField_4x4", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmFields", LocaEng = "(4x4) Farm field", LocaGer = "(4x4) Gemüseäcker", LocaFra = "(4x4) Champ agricole", LocaPol = "(4x4) Pole", LocaRus = "(4x4) Поле" });

            return result;
        }

        private static IEnumerable<ExtraPreset> GetExtraPresetsForAnno2070()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_281.png", Identifier = "black_smoker_miner_gold_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Gold Metal converter", LocaGer = "Metallkonverter Gold", LocaFra = "L'or Convertisseur métallique", LocaPol = "Konwerter warstw złotonośnych", LocaRus = "Конвертер золота" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_282.png", Identifier = "black_smoker_miner_copper_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Copper Metal converter", LocaGer = "Metallkonverter Kupfer", LocaFra = "Copère Convertisseur métallique", LocaPol = "Konwerter warstw miedzionośnych", LocaRus = "Конвертер меди" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_283.png", Identifier = "black_smoker_miner_uranium_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Uranium Metal converter", LocaGer = "Metallkonverter Uran", LocaFra = "L'uranium Convertisseur métallique", LocaPol = "Konwerter warstw bogatych w uran", LocaRus = "Конвертер урана" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 6, Faction = "Others", Group = "Black Smokers (Deep Sea)", Header = "(A5) Anno 2070", IconFileName = "icon_30_280.png", Identifier = "black_smoker_miner_iron_II", InfluenceRadius = 0, InfluenceRange = 0, Template = "FarmBuilding", LocaEng = "Iron Metal converter", LocaGer = "Metallkonverter Eisen", LocaFra = "Fer Convertisseur métallique", LocaPol = "Konwerter żelaza", LocaRus = "Конвертер железа" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 4, Faction = "Others", Group = "Public", Header = "(A5) Anno 2070", IconFileName = "icon_27_10.png", Identifier = "markethouse", InfluenceRadius = 20, InfluenceRange = 0, Template = "Markethouse", LocaEng = "Depot", LocaGer = "Warendepot", LocaFra = "Dépôt", LocaPol = "Skład", LocaRus = "Хранилище" });

            return result;
        }

        private static IEnumerable<ExtraPreset> GetExtraPresetsForAnno1800()
        {
            var result = new List<ExtraPreset>();

            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(02) Workers", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(03) Artisans", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(04) Engineers", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(05) Investors", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(07) Jornaleros", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(08) Obreros", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(10) Explorers", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 5, Faction = "(11) Technicians", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_warehouse.png", Identifier = "Logistic_02 (Warehouse I)", InfluenceRadius = 0, InfluenceRange = 0, Template = "Warehouse", LocaEng = "Small Warehouse", LocaGer = "Lagerhaus", LocaFra = "Petit entrepôt", LocaPol = "Mały magazyn", LocaRus = "Маленький склад" });
            result.Add(new ExtraPreset { BuildBlockerX = 6, BuildBlockerZ = 4, Faction = "Attractiveness", Group = "Modules", Header = "(A7) Anno 1800", IconFileName = "A7_Zoo module.png", Identifier = "Culture_01_module", InfluenceRadius = 0, InfluenceRange = 0, Template = "CultureModule", LocaEng = "Zoo Module (6x4)", LocaGer = "Zoo-Modul (6x4)", LocaFra = "Module du zoo (6x4)", LocaPol = "Moduł ZOO (6x4)", LocaRus = "Модуль зоопарка (6x4)" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 4, Faction = "Attractiveness", Group = "Modules", Header = "(A7) Anno 1800", IconFileName = "A7_Museum module.png", Identifier = "Culture_02_module", InfluenceRadius = 0, InfluenceRange = 0, Template = "CultureModule", LocaEng = "Museum Module (5x4)", LocaGer = "Museumsmodul (5x4)", LocaFra = "Module du musée (5x4)", LocaPol = "Moduł Muzeum (5x4)", LocaRus = "Модуль музея (5x4)" });
            result.Add(new ExtraPreset { BuildBlockerX = 5, BuildBlockerZ = 4, Faction = "Attractiveness", Group = "Modules", Header = "(A7) Anno 1800", IconFileName = "A7_botanic_module.png", Identifier = "Culture_03_module", InfluenceRadius = 0, InfluenceRange = 0, Template = "CultureModule", LocaEng = "Botanica Module (5x4)", LocaGer = "Botanikmodul (5x4)", LocaFra = "Module Botanica (5x4)", LocaPol = "Moduł botaniczny (5x4)", LocaRus = "модуль Ботанический (5x4)" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_44.png", Identifier = "Park_1x1_appletree", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Apple Tree", LocaGer = "Apfelbaum", LocaFra = "Pommier", LocaPol = "Jabłoń", LocaRus = "Яблоня" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_40.png", Identifier = "Park_1x1_elmtree", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Elm Tree", LocaGer = "Ulme", LocaFra = "L'orme", LocaPol = "Wiąz", LocaRus = "Вяз" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_39.png", Identifier = "Park_1x1_grownbush", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Mature Shrubbery", LocaGer = "Großes Gebüsch", LocaFra = "Arbustes matures", LocaPol = "Dojrzałe krzewy", LocaRus = "Кустарник" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_1x1_26.png", Identifier = "Park_1x1_bush", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Shrubbery", LocaGer = "Gebüsch", LocaFra = "Arbustes", LocaPol = "Krzewy", LocaRus = "Кустарник" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_temperateforest.png", Identifier = "Park_1x1_temperateforest", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Temperate Grove", LocaGer = "Laubbaum", LocaFra = "Bosquet tempéré", LocaPol = "Zagajnik klimatu umiarkowanego", LocaRus = "Лиственная роща" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_43.png", Identifier = "Park_1x1_tremblingaspen", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Trembling Aspen", LocaGer = "Zitterpappel", LocaFra = "Peuplier faux-tremble", LocaPol = "Topola osikowa", LocaRus = "Осина" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "04 Park Fountains", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_45.png", Identifier = "Park_1x1_wateringplace", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Watering Hole", LocaGer = "Alte Tränke", LocaFra = "Trou d'arrosage", LocaPol = "Wodopój", LocaRus = "Водопой" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "06 Park Decorations", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_46.png", Identifier = "Park_1x1_well", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Well", LocaGer = "Brunnen", LocaFra = "Puits", LocaPol = "Studnia", LocaRus = "Колодец" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "Ornaments", Group = "03 Park Vegetation", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_system_1x1_38.png", Identifier = "Park_1x1_flowerbed", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Flower Bed", LocaGer = "Blumenbeet", LocaFra = "Lit de fleurs", LocaPol = "Klomb", LocaRus = "Цветочная поляна" });
            result.Add(new ExtraPreset { BuildBlockerX = 2, BuildBlockerZ = 2, Faction = "Ornaments", Group = "05 Park Statues", Header = "(A7) Anno 1800", IconFileName = "A7_park_props_2x2_02.png", Identifier = "Park_2x2_manstatue", InfluenceRadius = 0, InfluenceRange = 0, Template = "OrnamentalBuilding_Park", LocaEng = "Memorial Garden", LocaGer = "Gedenkgarten", LocaFra = "Jardin Commémoratif", LocaPol = "Ogród pamięci", LocaRus = "Памятный сад" });
            result.Add(new ExtraPreset { BuildBlockerX = 22, BuildBlockerZ = 18, Faction = "Attractiveness", Group = null, Header = "(A7) Anno 1800", IconFileName = "A7_world_fair_2.png", Identifier = "Worlds_Fair_Foundation", InfluenceRadius = 0, InfluenceRange = 0, Template = "WorldsFairFoundation", LocaEng = "World's Fair (Foundation)", LocaGer = "Weltausstellung (Fundament)", LocaFra = "Exposition universelle (Fondation)", LocaPol = "Światowe Targi (Fundacja)", LocaRus = "Всемирная ярмарка (Фонд)" });
            result.Add(new ExtraPreset { BuildBlockerX = 3, BuildBlockerZ = 4, Faction = "(10) Explorers", Group = "Public Buildings", Header = "(A7) Anno 1800", IconFileName = "A7_heating_center.png", Identifier = "Heater_Arctic", InfluenceRadius = 0, InfluenceRange = 21, Template = "Heater_Arctic", LocaEng = "Heater", LocaGer = "Heizgerät", LocaFra = "Chaufferie", LocaPol = "Kotłownia", LocaRus = "Подогреватель" });
            result.Add(new ExtraPreset { BuildBlockerX = 4, BuildBlockerZ = 4, Faction = "(13) Scholars", Group = "Residence", Header = "(A7) Anno 1800", IconFileName = "A7_residence_scholars.png", Identifier = "Scholar_Residence", InfluenceRadius = 0, InfluenceRange = 0, Template = "ResidenceBuilding7_Scholars", LocaEng = "Scholar Residence", LocaGer = "Gelehrten-Residenz", LocaFra = "Résidence universitaire", LocaPol = "Rezydencja akademicka", LocaRus = "научная резиденция" });
            result.Add(new ExtraPreset { BuildBlockerX = 1, BuildBlockerZ = 1, Faction = "(15) Elders", Group = null, Header = "(A7) Anno 1800", IconFileName = null, Identifier = "WaterCanal", InfluenceRadius = 0, InfluenceRange = 0, Template = "WaterCanal", LocaEng = "Irrigation Canal", LocaGer = "Bewässerungskanal", LocaFra = "Canal d'irrigation", LocaPol = "Kanał Irygacyjny", LocaRus = "Ирригационный канал" });
            return result;
        }
    }
}
