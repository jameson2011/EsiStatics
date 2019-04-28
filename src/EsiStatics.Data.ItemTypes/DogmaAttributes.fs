﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module  DogmaAttributes=
    let getDogmaAttribute id = 
      let bkt = id % 97
      match bkt with
        | 0 -> DogmaAttributes0.getDogmaAttribute id
        | 1 -> DogmaAttributes1.getDogmaAttribute id
        | 2 -> DogmaAttributes2.getDogmaAttribute id
        | 3 -> DogmaAttributes3.getDogmaAttribute id
        | 4 -> DogmaAttributes4.getDogmaAttribute id
        | 5 -> DogmaAttributes5.getDogmaAttribute id
        | 6 -> DogmaAttributes6.getDogmaAttribute id
        | 7 -> DogmaAttributes7.getDogmaAttribute id
        | 8 -> DogmaAttributes8.getDogmaAttribute id
        | 9 -> DogmaAttributes9.getDogmaAttribute id
        | 10 -> DogmaAttributes10.getDogmaAttribute id
        | 11 -> DogmaAttributes11.getDogmaAttribute id
        | 12 -> DogmaAttributes12.getDogmaAttribute id
        | 13 -> DogmaAttributes13.getDogmaAttribute id
        | 14 -> DogmaAttributes14.getDogmaAttribute id
        | 15 -> DogmaAttributes15.getDogmaAttribute id
        | 16 -> DogmaAttributes16.getDogmaAttribute id
        | 17 -> DogmaAttributes17.getDogmaAttribute id
        | 18 -> DogmaAttributes18.getDogmaAttribute id
        | 19 -> DogmaAttributes19.getDogmaAttribute id
        | 20 -> DogmaAttributes20.getDogmaAttribute id
        | 21 -> DogmaAttributes21.getDogmaAttribute id
        | 22 -> DogmaAttributes22.getDogmaAttribute id
        | 23 -> DogmaAttributes23.getDogmaAttribute id
        | 24 -> DogmaAttributes24.getDogmaAttribute id
        | 25 -> DogmaAttributes25.getDogmaAttribute id
        | 26 -> DogmaAttributes26.getDogmaAttribute id
        | 27 -> DogmaAttributes27.getDogmaAttribute id
        | 28 -> DogmaAttributes28.getDogmaAttribute id
        | 29 -> DogmaAttributes29.getDogmaAttribute id
        | 30 -> DogmaAttributes30.getDogmaAttribute id
        | 31 -> DogmaAttributes31.getDogmaAttribute id
        | 32 -> DogmaAttributes32.getDogmaAttribute id
        | 33 -> DogmaAttributes33.getDogmaAttribute id
        | 34 -> DogmaAttributes34.getDogmaAttribute id
        | 35 -> DogmaAttributes35.getDogmaAttribute id
        | 36 -> DogmaAttributes36.getDogmaAttribute id
        | 37 -> DogmaAttributes37.getDogmaAttribute id
        | 38 -> DogmaAttributes38.getDogmaAttribute id
        | 39 -> DogmaAttributes39.getDogmaAttribute id
        | 40 -> DogmaAttributes40.getDogmaAttribute id
        | 41 -> DogmaAttributes41.getDogmaAttribute id
        | 42 -> DogmaAttributes42.getDogmaAttribute id
        | 43 -> DogmaAttributes43.getDogmaAttribute id
        | 44 -> DogmaAttributes44.getDogmaAttribute id
        | 45 -> DogmaAttributes45.getDogmaAttribute id
        | 46 -> DogmaAttributes46.getDogmaAttribute id
        | 47 -> DogmaAttributes47.getDogmaAttribute id
        | 48 -> DogmaAttributes48.getDogmaAttribute id
        | 49 -> DogmaAttributes49.getDogmaAttribute id
        | 50 -> DogmaAttributes50.getDogmaAttribute id
        | 51 -> DogmaAttributes51.getDogmaAttribute id
        | 52 -> DogmaAttributes52.getDogmaAttribute id
        | 53 -> DogmaAttributes53.getDogmaAttribute id
        | 54 -> DogmaAttributes54.getDogmaAttribute id
        | 55 -> DogmaAttributes55.getDogmaAttribute id
        | 56 -> DogmaAttributes56.getDogmaAttribute id
        | 57 -> DogmaAttributes57.getDogmaAttribute id
        | 58 -> DogmaAttributes58.getDogmaAttribute id
        | 59 -> DogmaAttributes59.getDogmaAttribute id
        | 60 -> DogmaAttributes60.getDogmaAttribute id
        | 61 -> DogmaAttributes61.getDogmaAttribute id
        | 62 -> DogmaAttributes62.getDogmaAttribute id
        | 63 -> DogmaAttributes63.getDogmaAttribute id
        | 64 -> DogmaAttributes64.getDogmaAttribute id
        | 65 -> DogmaAttributes65.getDogmaAttribute id
        | 66 -> DogmaAttributes66.getDogmaAttribute id
        | 67 -> DogmaAttributes67.getDogmaAttribute id
        | 68 -> DogmaAttributes68.getDogmaAttribute id
        | 69 -> DogmaAttributes69.getDogmaAttribute id
        | 70 -> DogmaAttributes70.getDogmaAttribute id
        | 71 -> DogmaAttributes71.getDogmaAttribute id
        | 72 -> DogmaAttributes72.getDogmaAttribute id
        | 73 -> DogmaAttributes73.getDogmaAttribute id
        | 74 -> DogmaAttributes74.getDogmaAttribute id
        | 75 -> DogmaAttributes75.getDogmaAttribute id
        | 76 -> DogmaAttributes76.getDogmaAttribute id
        | 77 -> DogmaAttributes77.getDogmaAttribute id
        | 78 -> DogmaAttributes78.getDogmaAttribute id
        | 79 -> DogmaAttributes79.getDogmaAttribute id
        | 80 -> DogmaAttributes80.getDogmaAttribute id
        | 81 -> DogmaAttributes81.getDogmaAttribute id
        | 82 -> DogmaAttributes82.getDogmaAttribute id
        | 83 -> DogmaAttributes83.getDogmaAttribute id
        | 84 -> DogmaAttributes84.getDogmaAttribute id
        | 85 -> DogmaAttributes85.getDogmaAttribute id
        | 86 -> DogmaAttributes86.getDogmaAttribute id
        | 87 -> DogmaAttributes87.getDogmaAttribute id
        | 88 -> DogmaAttributes88.getDogmaAttribute id
        | 89 -> DogmaAttributes89.getDogmaAttribute id
        | 90 -> DogmaAttributes90.getDogmaAttribute id
        | 91 -> DogmaAttributes91.getDogmaAttribute id
        | 92 -> DogmaAttributes92.getDogmaAttribute id
        | 93 -> DogmaAttributes93.getDogmaAttribute id
        | 94 -> DogmaAttributes94.getDogmaAttribute id
        | 95 -> DogmaAttributes95.getDogmaAttribute id
        | 96 -> DogmaAttributes96.getDogmaAttribute id
        | _ -> None
    let dogmaAttributes =
        let ids =  [| 1000; 1001; 1002; 1003; 1004; 1005; 1006; 1007; 1008; 1009; 101; 1010; 1011; 1012; 1013; 1014; 1015; 1016; 1017; 1018; 1019; 102; 1020; 1021; 1022; 1023; 1024; 1025; 1026; 1027; 1028; 1029; 103; 1030; 1031; 1032; 1033; 1034; 1035; 104; 1045; 1047; 1048; 105; 106; 107; 1073; 1074; 1075; 1076; 1077; 1079; 108; 1080; 1081; 1082; 1083; 1084; 1085; 1086; 1087; 1088; 1089; 109; 1090; 1091; 1092; 1093; 1094; 1095; 1096; 1097; 1098; 1099; 11; 110; 1100; 1101; 1102; 1103; 1104; 1105; 1106; 1107; 1108; 1109; 111; 1110; 1111; 1112; 1113; 1114; 1115; 1116; 1117; 1118; 1119; 112; 1120; 1121; 1122; 1123; 1124; 1125; 1126; 1127; 1128; 1129; 113; 1130; 1131; 1132; 1133; 1134; 1135; 1136; 1137; 1138; 1139; 114; 1141; 1142; 1143; 1144; 1145; 1146; 1147; 1148; 1149; 1150; 1151; 1152; 1153; 1154; 1155; 1156; 1157; 1158; 1159; 116; 1160; 1161; 1162; 1163; 1164; 1165; 1167; 1168; 1169; 117; 1170; 1171; 1172; 1173; 1174; 1175; 1176; 1177; 1178; 1179; 118; 1180; 1181; 1182; 1183; 1184; 1185; 1190; 1191; 1192; 1193; 1194; 1195; 1196; 1198; 1199; 12; 120; 1200; 1205; 1206; 1207; 1208; 1209; 121; 1210; 1211; 1212; 1213; 1214; 1216; 1218; 1219; 122; 1220; 1221; 1222; 1223; 1224; 1225; 1226; 1227; 1228; 1229; 123; 1230; 1231; 1233; 1234; 1235; 1236; 1237; 1238; 1239; 124; 1240; 1243; 1244; 1245; 1246; 1247; 1249; 125; 1250; 1251; 1252; 1253; 1254; 1255; 1256; 1257; 1258; 1259; 126; 1261; 1262; 1263; 1264; 1265; 1266; 1267; 1268; 1269; 127; 1270; 1271; 1272; 1273; 1274; 1275; 1276; 1277; 1278; 1279; 128; 1280; 1281; 1282; 1283; 1284; 1285; 1286; 1287; 1288; 1289; 129; 1290; 1291; 1292; 1293; 1294; 1295; 1296; 1297; 1298; 1299; 13; 130; 1300; 1301; 1302; 1303; 1304; 1305; 1306; 1307; 1308; 1309; 131; 1310; 1311; 1312; 1313; 1314; 1315; 1316; 1317; 1318; 1319; 132; 1320; 1321; 1322; 1323; 1324; 1325; 1326; 1327; 1328; 1329; 133; 1330; 1331; 1332; 1333; 1334; 1335; 1336; 1337; 1339; 134; 1340; 1341; 1349; 135; 1350; 1351; 1352; 1353; 1354; 1355; 1356; 1357; 1358; 1359; 136; 1360; 1361; 1366; 1367; 1368; 1369; 137; 1370; 1371; 1372; 1373; 1374; 1375; 1376; 1377; 1378; 1379; 138; 1380; 1381; 1382; 1383; 1384; 1385; 1386; 1387; 1388; 1389; 139; 1390; 1391; 1392; 1393; 1394; 1395; 1396; 1397; 1398; 1399; 14; 140; 1400; 1401; 1402; 1403; 1404; 1405; 1406; 1407; 1408; 1409; 141; 1410; 1411; 1412; 1413; 1414; 1416; 1417; 1418; 1419; 142; 1420; 1421; 1422; 1423; 1424; 1425; 1426; 1427; 1428; 1429; 143; 1430; 1431; 1432; 1433; 1434; 1435; 1436; 1437; 1438; 1439; 144; 1440; 1441; 1442; 1443; 1444; 1445; 1446; 1447; 1448; 1449; 145; 1450; 1451; 1453; 1454; 1455; 1456; 1457; 1458; 1459; 146; 1460; 1462; 1464; 1465; 1466; 1467; 1468; 1469; 147; 1470; 1471; 1472; 1473; 1474; 1475; 1476; 1477; 1478; 1479; 148; 1480; 1481; 1482; 1483; 1484; 1485; 1486; 1487; 1488; 1489; 149; 1490; 1491; 1492; 1493; 1494; 1495; 1496; 1497; 1498; 1499; 15; 150; 1500; 1501; 1502; 1503; 1504; 1505; 1506; 1507; 1508; 1509; 151; 1510; 1511; 1512; 1513; 1514; 1515; 1516; 1517; 1518; 1519; 152; 1520; 1521; 1522; 1523; 1524; 1525; 1526; 1527; 1528; 1529; 153; 1530; 1531; 1532; 1533; 1534; 1535; 1536; 1537; 1538; 1539; 154; 1540; 1541; 1544; 1547; 1549; 1550; 1551; 1552; 1553; 1554; 1555; 1556; 1557; 1558; 1559; 156; 1560; 1561; 1562; 1563; 1564; 1565; 1566; 1567; 1568; 1569; 157; 1570; 1571; 1572; 1573; 1574; 1575; 1576; 1577; 1578; 1579; 158; 1580; 1581; 1582; 1583; 1584; 1585; 1586; 1590; 1591; 1595; 1597; 1598; 1599; 160; 1600; 1601; 1603; 1606; 1607; 1608; 1609; 161; 1610; 1611; 1612; 1613; 1614; 1615; 1616; 1619; 162; 1623; 1624; 1625; 1626; 163; 1631; 1632; 1633; 1634; 1635; 1636; 1638; 1639; 164; 1640; 1641; 1642; 1643; 1644; 1645; 1646; 1647; 1648; 1649; 165; 1650; 1651; 1652; 1653; 1654; 1655; 1656; 1657; 1658; 1659; 166; 1660; 1661; 1662; 1663; 1664; 1669; 167; 1670; 1671; 1672; 1673; 1674; 1675; 1676; 1677; 1678; 1679; 168; 1680; 1681; 1682; 1683; 1684; 1685; 1686; 1687; 1688; 1689; 169; 1690; 1691; 1692; 1695; 1696; 1697; 1698; 1699; 170; 1700; 1701; 1702; 1703; 1704; 1705; 1706; 1707; 1708; 1709; 171; 1710; 1711; 1712; 1713; 1714; 1715; 1716; 1717; 1718; 1719; 172; 1720; 1721; 1722; 1723; 1724; 1725; 1726; 1727; 1728; 1729; 173; 1730; 1731; 1732; 1733; 1734; 1735; 1736; 1737; 1738; 1739; 174; 1740; 1741; 1742; 1743; 1744; 1745; 1746; 1747; 1748; 1749; 175; 1750; 1751; 1752; 1753; 1754; 1755; 1756; 1757; 1758; 1759; 176; 1760; 1761; 1762; 1763; 1764; 1766; 1768; 177; 1770; 1771; 1772; 1773; 1775; 1778; 178; 1780; 1781; 1782; 1783; 1785; 1786; 1787; 1788; 179; 1790; 1791; 1792; 1793; 1794; 1795; 1797; 1798; 1799; 18; 180; 1803; 1804; 1806; 1808; 1809; 181; 1811; 1812; 1813; 1814; 1815; 1816; 1817; 1818; 182; 1820; 1821; 1822; 1823; 1824; 1825; 1826; 1827; 1828; 1829; 183; 1830; 1831; 1832; 1833; 1834; 1835; 1836; 1837; 1838; 1839; 184; 1840; 1842; 1843; 1844; 1845; 1846; 1847; 1848; 1849; 185; 1851; 1852; 1854; 1855; 1856; 1857; 1858; 1859; 186; 1860; 1861; 1862; 1863; 1864; 1865; 1866; 1867; 1868; 1869; 187; 1870; 1871; 1872; 1879; 188; 1880; 1881; 1882; 1883; 1886; 1887; 1888; 1889; 189; 1890; 1891; 1892; 1893; 1894; 1895; 1896; 1897; 19; 190; 1904; 1905; 1906; 1907; 1908; 1909; 191; 1910; 1911; 1912; 1913; 1914; 1915; 1916; 1917; 1918; 1919; 192; 1920; 1921; 1922; 1923; 1924; 1925; 1926; 1927; 1928; 1929; 193; 1930; 1932; 1933; 1934; 1935; 1936; 1937; 1938; 1939; 194; 1940; 1941; 1942; 1943; 1944; 1945; 1946; 1949; 195; 1950; 1951; 1952; 1954; 1955; 1956; 1957; 1958; 1959; 196; 1961; 1966; 1967; 1968; 1969; 197; 1970; 1971; 1972; 1973; 1974; 1975; 1978; 1979; 1980; 1981; 1982; 1983; 1984; 1985; 1986; 1987; 1988; 1989; 1990; 1991; 1992; 1993; 1994; 1995; 1996; 1997; 1998; 1999; 2; 20; 2000; 2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2012; 2013; 2014; 2015; 2016; 2017; 2018; 2019; 202; 2020; 2021; 2023; 2024; 2025; 2026; 2027; 2028; 2029; 203; 2030; 2031; 2032; 2033; 2034; 2035; 2036; 2037; 2038; 2039; 204; 2041; 2042; 2043; 2044; 2045; 2046; 2047; 2048; 2049; 205; 2055; 2056; 2058; 2059; 2060; 2061; 2063; 2064; 2065; 2066; 2067; 2069; 207; 2070; 2071; 2072; 2073; 2074; 2075; 2076; 2077; 2078; 2079; 208; 2080; 2081; 2082; 2083; 2084; 2085; 2086; 2087; 2088; 2089; 209; 2090; 2091; 2092; 2093; 2094; 2095; 2096; 2097; 2098; 2099; 21; 210; 2100; 2101; 2102; 2103; 2104; 2105; 2106; 2107; 2108; 2109; 211; 2110; 2111; 2112; 2113; 2114; 2115; 2116; 2118; 2119; 212; 2120; 2121; 2123; 2125; 2126; 2127; 2128; 213; 2130; 2131; 2132; 2133; 2134; 2135; 2136; 2137; 2138; 2139; 2140; 2141; 2142; 2143; 2144; 2145; 2147; 2148; 2149; 2150; 2151; 2152; 2153; 2154; 2155; 2156; 2157; 2158; 216; 217; 2170; 2171; 2172; 2173; 2174; 2175; 2176; 2177; 2178; 2179; 218; 2180; 2182; 2183; 2184; 2185; 2186; 2187; 2188; 2189; 219; 220; 2203; 2204; 2205; 2206; 2207; 2208; 2209; 221; 2210; 2211; 2212; 2213; 2214; 2215; 2216; 2217; 2218; 2219; 222; 2220; 2221; 2222; 2223; 2224; 2225; 2226; 2227; 2228; 2229; 223; 2230; 2231; 2232; 2233; 2234; 2235; 2236; 2237; 2238; 2239; 224; 2242; 2243; 2244; 2246; 2247; 2248; 2249; 225; 2250; 2251; 2252; 2253; 2255; 2256; 2257; 2258; 2259; 226; 2260; 2261; 2262; 2263; 2264; 2265; 2266; 2267; 2268; 2269; 227; 2270; 2271; 2272; 2273; 2274; 2275; 2276; 2277; 2278; 2279; 228; 2280; 2281; 2282; 2283; 2284; 2285; 2286; 2287; 2288; 2289; 229; 2290; 2291; 2292; 2293; 2294; 2298; 2299; 230; 2300; 2301; 2302; 2303; 2304; 2305; 2306; 2307; 2308; 2309; 231; 2310; 2311; 2312; 2313; 2314; 2315; 2316; 2317; 2318; 2319; 232; 2320; 2321; 2322; 2323; 2324; 2325; 2326; 2327; 2328; 2329; 2330; 2333; 2334; 2335; 2336; 2337; 2338; 2339; 2340; 2342; 2343; 2344; 2345; 2346; 2347; 2348; 2349; 235; 2351; 2352; 2353; 2354; 2355; 2356; 2357; 2358; 2359; 236; 2360; 2361; 2362; 2363; 2364; 2365; 2366; 2367; 2368; 2369; 237; 2370; 2371; 2372; 2373; 2374; 2375; 2376; 2377; 2378; 2379; 238; 2380; 2381; 2382; 2383; 2384; 2385; 2386; 2387; 2388; 2389; 239; 2390; 2391; 2392; 2393; 2394; 2395; 2396; 2397; 2398; 2399; 240; 2400; 2401; 2402; 2403; 2404; 2405; 2406; 2407; 2408; 2409; 241; 2410; 2411; 2412; 2413; 2414; 2415; 2416; 2417; 2418; 2419; 242; 2420; 2421; 2422; 2423; 2424; 2425; 2426; 2427; 2428; 2429; 243; 2430; 2431; 2432; 2433; 2434; 2435; 2436; 2437; 2438; 2439; 244; 2440; 2441; 2442; 2444; 2445; 2446; 2447; 2448; 2449; 245; 2450; 2451; 2452; 2453; 2454; 2455; 2456; 2457; 2458; 2459; 246; 2460; 2461; 2462; 2463; 2464; 2467; 2468; 2469; 247; 2470; 2471; 2472; 2473; 2474; 2475; 2476; 2477; 2478; 2479; 248; 2480; 2481; 2482; 2483; 2484; 2485; 2486; 2487; 2488; 2489; 249; 2490; 2491; 2492; 2493; 2494; 2495; 2496; 2497; 2498; 2499; 250; 2500; 2501; 2502; 2503; 2504; 2505; 2506; 2507; 2508; 2509; 251; 2510; 2511; 2512; 2513; 2514; 2515; 2516; 2517; 2518; 2519; 252; 2520; 2521; 2522; 2523; 2524; 2525; 2526; 2527; 2528; 2529; 253; 2530; 2531; 2532; 2533; 2534; 2535; 2536; 2537; 2538; 2539; 254; 2540; 2541; 2542; 2543; 2544; 2545; 2546; 2547; 2548; 2549; 2550; 2551; 2552; 2553; 2555; 2556; 2557; 2558; 2559; 256; 2560; 2561; 2562; 2563; 2564; 2565; 2566; 2567; 2568; 2569; 257; 2570; 2571; 2572; 2573; 2574; 2575; 2576; 2577; 2578; 2579; 258; 2580; 2581; 2582; 2583; 2584; 2585; 2586; 2587; 2588; 2589; 259; 2590; 2591; 2592; 2593; 2594; 2595; 2596; 2597; 2598; 2599; 260; 2600; 2601; 2602; 2603; 2604; 2605; 2606; 2607; 2608; 2609; 261; 2610; 2612; 2613; 2614; 2615; 2616; 2617; 2618; 2619; 262; 2620; 2621; 2622; 2623; 2624; 2627; 2628; 2629; 263; 2630; 2631; 2632; 2633; 2634; 2635; 2636; 2637; 2638; 2639; 264; 2640; 2641; 2642; 2643; 2644; 2645; 2646; 2647; 2648; 2649; 265; 2653; 2654; 2655; 2656; 2657; 2658; 2659; 266; 2660; 2661; 2662; 2664; 2665; 2666; 2667; 2668; 2669; 267; 2670; 2671; 2673; 2674; 2675; 2676; 2677; 2678; 2679; 268; 2680; 2681; 2682; 2683; 2684; 2685; 2686; 2687; 2688; 2689; 269; 2690; 2691; 2692; 2693; 2694; 2695; 2696; 2697; 2698; 2699; 270; 2700; 2701; 2704; 2705; 2706; 2707; 2708; 2709; 271; 2710; 2711; 2713; 2714; 2715; 2716; 2717; 2718; 2719; 272; 2720; 2721; 2722; 2723; 2724; 2725; 2727; 2728; 2729; 273; 2730; 2731; 2732; 2733; 2734; 2735; 2736; 2737; 2738; 2739; 274; 2740; 2741; 2742; 2743; 2744; 2745; 2746; 2747; 2748; 2749; 275; 2750; 2751; 2752; 2753; 2754; 2755; 2756; 2757; 2758; 2759; 276; 2760; 2761; 2762; 2763; 2764; 2765; 2766; 2767; 2768; 2769; 277; 2770; 2771; 2772; 2773; 2774; 2775; 2776; 2777; 2778; 2779; 278; 2780; 2781; 2782; 2783; 2784; 2785; 2786; 2787; 2788; 2789; 279; 2790; 2791; 2792; 2793; 2794; 2795; 2796; 2797; 2798; 2799; 280; 2800; 2801; 2802; 2803; 2804; 2805; 2806; 2807; 2808; 2809; 281; 2810; 2811; 282; 2820; 2821; 283; 284; 285; 286; 287; 288; 289; 29; 290; 291; 292; 293; 294; 295; 296; 297; 298; 299; 3; 30; 300; 301; 302; 303; 304; 305; 306; 307; 308; 309; 31; 310; 311; 312; 313; 314; 315; 316; 317; 318; 319; 32; 320; 321; 322; 323; 324; 325; 326; 327; 328; 329; 330; 331; 332; 333; 334; 335; 336; 337; 338; 349; 350; 351; 352; 353; 354; 355; 356; 359; 360; 361; 362; 363; 364; 365; 366; 367; 368; 369; 37; 370; 371; 372; 373; 374; 375; 376; 377; 378; 379; 38; 380; 383; 384; 385; 386; 387; 388; 389; 39; 392; 393; 394; 395; 396; 397; 398; 399; 4; 400; 401; 402; 403; 404; 405; 406; 407; 408; 409; 410; 411; 412; 413; 414; 415; 416; 417; 418; 419; 420; 421; 422; 423; 424; 425; 426; 427; 428; 429; 430; 431; 432; 433; 434; 435; 436; 437; 438; 439; 440; 441; 442; 443; 444; 445; 446; 447; 448; 449; 450; 451; 452; 453; 454; 455; 456; 457; 458; 459; 460; 461; 462; 463; 464; 465; 466; 467; 468; 469; 47; 470; 471; 472; 473; 474; 475; 476; 478; 479; 48; 480; 481; 482; 484; 485; 486; 487; 488; 489; 49; 490; 491; 492; 493; 494; 495; 496; 497; 499; 50; 500; 501; 502; 503; 504; 505; 506; 507; 508; 509; 51; 510; 511; 512; 513; 514; 515; 516; 517; 518; 519; 52; 522; 524; 525; 526; 527; 528; 529; 530; 531; 532; 534; 535; 536; 537; 538; 54; 542; 543; 544; 545; 546; 547; 548; 549; 55; 550; 551; 552; 553; 554; 555; 556; 557; 558; 559; 56; 560; 561; 562; 563; 564; 565; 566; 567; 568; 569; 570; 571; 573; 575; 579; 580; 581; 582; 583; 584; 585; 586; 587; 588; 589; 590; 591; 592; 594; 595; 596; 597; 598; 6; 600; 601; 602; 603; 604; 605; 606; 608; 609; 61; 610; 611; 612; 613; 614; 616; 619; 620; 621; 622; 623; 624; 625; 626; 627; 628; 629; 63; 630; 631; 632; 633; 634; 635; 636; 637; 638; 639; 64; 640; 643; 644; 645; 646; 647; 648; 649; 65; 650; 651; 652; 653; 654; 655; 656; 657; 658; 659; 66; 660; 661; 662; 663; 664; 665; 666; 667; 668; 669; 67; 670; 672; 673; 675; 676; 677; 678; 679; 68; 680; 681; 682; 683; 684; 685; 686; 687; 688; 689; 69; 690; 691; 692; 693; 694; 695; 696; 697; 698; 699; 70; 700; 701; 703; 704; 705; 706; 707; 708; 709; 710; 711; 712; 713; 714; 715; 716; 717; 719; 72; 720; 721; 722; 723; 724; 725; 726; 727; 728; 729; 73; 732; 733; 734; 735; 738; 739; 740; 741; 742; 743; 745; 746; 747; 748; 749; 75; 750; 751; 752; 753; 754; 755; 756; 757; 758; 759; 76; 760; 761; 762; 763; 764; 765; 766; 767; 769; 77; 770; 771; 772; 773; 774; 775; 776; 777; 778; 779; 780; 781; 782; 783; 784; 785; 786; 787; 788; 789; 79; 790; 791; 792; 793; 794; 795; 796; 797; 798; 799; 8; 80; 800; 801; 802; 803; 804; 805; 806; 807; 808; 809; 81; 811; 813; 814; 815; 816; 817; 818; 82; 823; 828; 829; 83; 830; 831; 832; 833; 834; 837; 838; 839; 84; 840; 841; 842; 843; 844; 845; 846; 847; 848; 849; 850; 851; 852; 853; 854; 855; 857; 858; 859; 860; 861; 862; 863; 864; 865; 866; 867; 868; 869; 87; 870; 871; 872; 874; 88; 884; 885; 886; 887; 888; 889; 89; 890; 891; 892; 893; 894; 895; 896; 897; 898; 899; 9; 90; 901; 902; 903; 904; 905; 906; 907; 908; 909; 91; 910; 911; 912; 913; 915; 917; 919; 92; 921; 924; 925; 926; 927; 928; 929; 93; 930; 931; 932; 933; 935; 936; 937; 938; 940; 941; 942; 943; 944; 945; 946; 947; 948; 949; 95; 950; 951; 952; 953; 954; 955; 956; 957; 958; 959; 96; 960; 961; 962; 963; 964; 965; 966; 967; 968; 969; 97; 970; 971; 972; 973; 974; 975; 976; 977; 978; 979; 98; 980; 981; 982; 983; 984; 985; 986; 987; 988; 989; 99; 990; 991; 992; 993; 994; 995; 996; 997; 998; 999 |] 
        (fun () -> ids |> Seq.map getDogmaAttribute |> Seq.filter Option.isSome |> Seq.map Option.get )