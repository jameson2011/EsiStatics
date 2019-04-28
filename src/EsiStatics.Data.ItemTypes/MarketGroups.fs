﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module  MarketGroups=
    let getMarketGroup id = 
      let bkt = id % 97
      match bkt with
        | 0 -> MarketGroups0.getMarketGroup id
        | 1 -> MarketGroups1.getMarketGroup id
        | 2 -> MarketGroups2.getMarketGroup id
        | 3 -> MarketGroups3.getMarketGroup id
        | 4 -> MarketGroups4.getMarketGroup id
        | 5 -> MarketGroups5.getMarketGroup id
        | 6 -> MarketGroups6.getMarketGroup id
        | 7 -> MarketGroups7.getMarketGroup id
        | 8 -> MarketGroups8.getMarketGroup id
        | 9 -> MarketGroups9.getMarketGroup id
        | 10 -> MarketGroups10.getMarketGroup id
        | 11 -> MarketGroups11.getMarketGroup id
        | 12 -> MarketGroups12.getMarketGroup id
        | 13 -> MarketGroups13.getMarketGroup id
        | 14 -> MarketGroups14.getMarketGroup id
        | 15 -> MarketGroups15.getMarketGroup id
        | 16 -> MarketGroups16.getMarketGroup id
        | 17 -> MarketGroups17.getMarketGroup id
        | 18 -> MarketGroups18.getMarketGroup id
        | 19 -> MarketGroups19.getMarketGroup id
        | 20 -> MarketGroups20.getMarketGroup id
        | 21 -> MarketGroups21.getMarketGroup id
        | 22 -> MarketGroups22.getMarketGroup id
        | 23 -> MarketGroups23.getMarketGroup id
        | 24 -> MarketGroups24.getMarketGroup id
        | 25 -> MarketGroups25.getMarketGroup id
        | 26 -> MarketGroups26.getMarketGroup id
        | 27 -> MarketGroups27.getMarketGroup id
        | 28 -> MarketGroups28.getMarketGroup id
        | 29 -> MarketGroups29.getMarketGroup id
        | 30 -> MarketGroups30.getMarketGroup id
        | 31 -> MarketGroups31.getMarketGroup id
        | 32 -> MarketGroups32.getMarketGroup id
        | 33 -> MarketGroups33.getMarketGroup id
        | 34 -> MarketGroups34.getMarketGroup id
        | 35 -> MarketGroups35.getMarketGroup id
        | 36 -> MarketGroups36.getMarketGroup id
        | 37 -> MarketGroups37.getMarketGroup id
        | 38 -> MarketGroups38.getMarketGroup id
        | 39 -> MarketGroups39.getMarketGroup id
        | 40 -> MarketGroups40.getMarketGroup id
        | 41 -> MarketGroups41.getMarketGroup id
        | 42 -> MarketGroups42.getMarketGroup id
        | 43 -> MarketGroups43.getMarketGroup id
        | 44 -> MarketGroups44.getMarketGroup id
        | 45 -> MarketGroups45.getMarketGroup id
        | 46 -> MarketGroups46.getMarketGroup id
        | 47 -> MarketGroups47.getMarketGroup id
        | 48 -> MarketGroups48.getMarketGroup id
        | 49 -> MarketGroups49.getMarketGroup id
        | 50 -> MarketGroups50.getMarketGroup id
        | 51 -> MarketGroups51.getMarketGroup id
        | 52 -> MarketGroups52.getMarketGroup id
        | 53 -> MarketGroups53.getMarketGroup id
        | 54 -> MarketGroups54.getMarketGroup id
        | 55 -> MarketGroups55.getMarketGroup id
        | 56 -> MarketGroups56.getMarketGroup id
        | 57 -> MarketGroups57.getMarketGroup id
        | 58 -> MarketGroups58.getMarketGroup id
        | 59 -> MarketGroups59.getMarketGroup id
        | 60 -> MarketGroups60.getMarketGroup id
        | 61 -> MarketGroups61.getMarketGroup id
        | 62 -> MarketGroups62.getMarketGroup id
        | 63 -> MarketGroups63.getMarketGroup id
        | 64 -> MarketGroups64.getMarketGroup id
        | 65 -> MarketGroups65.getMarketGroup id
        | 66 -> MarketGroups66.getMarketGroup id
        | 67 -> MarketGroups67.getMarketGroup id
        | 68 -> MarketGroups68.getMarketGroup id
        | 69 -> MarketGroups69.getMarketGroup id
        | 70 -> MarketGroups70.getMarketGroup id
        | 71 -> MarketGroups71.getMarketGroup id
        | 72 -> MarketGroups72.getMarketGroup id
        | 73 -> MarketGroups73.getMarketGroup id
        | 74 -> MarketGroups74.getMarketGroup id
        | 75 -> MarketGroups75.getMarketGroup id
        | 76 -> MarketGroups76.getMarketGroup id
        | 77 -> MarketGroups77.getMarketGroup id
        | 78 -> MarketGroups78.getMarketGroup id
        | 79 -> MarketGroups79.getMarketGroup id
        | 80 -> MarketGroups80.getMarketGroup id
        | 81 -> MarketGroups81.getMarketGroup id
        | 82 -> MarketGroups82.getMarketGroup id
        | 83 -> MarketGroups83.getMarketGroup id
        | 84 -> MarketGroups84.getMarketGroup id
        | 85 -> MarketGroups85.getMarketGroup id
        | 86 -> MarketGroups86.getMarketGroup id
        | 87 -> MarketGroups87.getMarketGroup id
        | 88 -> MarketGroups88.getMarketGroup id
        | 89 -> MarketGroups89.getMarketGroup id
        | 90 -> MarketGroups90.getMarketGroup id
        | 91 -> MarketGroups91.getMarketGroup id
        | 92 -> MarketGroups92.getMarketGroup id
        | 93 -> MarketGroups93.getMarketGroup id
        | 94 -> MarketGroups94.getMarketGroup id
        | 95 -> MarketGroups95.getMarketGroup id
        | 96 -> MarketGroups96.getMarketGroup id
        | _ -> None
    let marketGroups =
        let ids =  [| 10; 100; 1000; 1001; 1002; 1003; 1004; 1006; 1007; 1008; 1009; 101; 1010; 1011; 1012; 1013; 1014; 1015; 1016; 1018; 1019; 102; 1021; 1022; 1027; 1028; 1029; 103; 1030; 1031; 1032; 1033; 1034; 1035; 1037; 1038; 1039; 1040; 1041; 1045; 1046; 1047; 1048; 1049; 105; 1050; 1051; 1052; 1053; 1054; 1055; 1056; 1057; 1058; 1059; 106; 1060; 1061; 1062; 1063; 1065; 1066; 1067; 1068; 1069; 107; 1070; 1071; 1072; 1073; 1074; 1075; 1076; 1077; 1078; 1079; 108; 1080; 1081; 1082; 1083; 1084; 1085; 1086; 1087; 1088; 1089; 109; 1090; 1091; 1092; 1093; 1094; 1097; 11; 1103; 1105; 1109; 1110; 1111; 1112; 112; 1122; 1123; 1124; 1125; 1126; 1127; 1128; 1129; 113; 1130; 1131; 1132; 1133; 1134; 1135; 1136; 1137; 1138; 1139; 114; 1140; 1141; 1142; 1147; 115; 116; 117; 118; 1191; 1192; 1193; 1194; 1195; 1196; 1197; 1198; 1199; 120; 1200; 1201; 1202; 1203; 1204; 1206; 1207; 1208; 1210; 1211; 1212; 1213; 1214; 1215; 1219; 1220; 1221; 1222; 1223; 1224; 1225; 1226; 1227; 1228; 1229; 1230; 1231; 1232; 1233; 1234; 1235; 1236; 1237; 1238; 1239; 1240; 1241; 1242; 1243; 1244; 1245; 1249; 1250; 1251; 1252; 1253; 1254; 1255; 1256; 1257; 1258; 1259; 126; 1260; 1261; 1262; 1263; 1264; 1265; 1266; 1267; 1268; 1269; 1272; 1273; 1274; 1275; 1276; 128; 1282; 1283; 1284; 1285; 1286; 1287; 131; 1310; 1313; 1316; 1317; 132; 1320; 1322; 1323; 133; 1332; 1333; 1334; 1335; 1336; 1337; 1338; 1339; 134; 1340; 1341; 1342; 1343; 1344; 1345; 1346; 1347; 1348; 1349; 135; 1350; 1351; 1352; 1353; 1354; 1355; 1356; 1358; 1359; 1361; 1362; 1364; 1365; 1366; 1367; 1368; 1369; 1370; 1371; 1372; 1373; 1374; 1375; 1376; 1377; 1378; 1379; 1380; 1381; 1382; 1384; 1385; 1389; 139; 1390; 1392; 1396; 1397; 1398; 1399; 14; 140; 1400; 1401; 1402; 1403; 1404; 1405; 1406; 1407; 1408; 141; 1410; 1416; 1426; 1427; 143; 1469; 1470; 1471; 1472; 1473; 1474; 1475; 1476; 1477; 1478; 1479; 1480; 1481; 1482; 1483; 1484; 1485; 1486; 1489; 1490; 1491; 1492; 1493; 1494; 1495; 1496; 1497; 1498; 1499; 150; 1500; 1501; 1502; 1504; 1505; 1506; 1507; 1508; 1509; 1512; 1513; 1514; 1515; 1516; 1517; 1518; 1520; 1521; 1522; 1525; 1526; 1527; 1528; 1529; 1530; 1531; 1532; 1533; 1534; 1535; 1536; 1537; 1538; 1539; 1540; 1541; 1542; 1543; 1544; 1545; 1546; 1547; 1548; 1549; 1550; 1551; 1552; 1553; 1554; 1555; 1556; 1557; 1558; 1559; 1560; 1561; 1562; 1563; 1564; 1565; 1566; 1567; 1568; 157; 1570; 1571; 1572; 1574; 1575; 1576; 1577; 1578; 1579; 158; 1580; 1581; 1582; 1583; 1584; 1585; 1586; 1587; 1588; 1589; 159; 1590; 1591; 1592; 1593; 1594; 1595; 1598; 1599; 1600; 1601; 1602; 1603; 1610; 1612; 1614; 1616; 1617; 1618; 1619; 1620; 1621; 1623; 1624; 1625; 1626; 1627; 1631; 1633; 1639; 1640; 1641; 1642; 1643; 1646; 1650; 1651; 1652; 1653; 1657; 1658; 1659; 1660; 1661; 1662; 1663; 1664; 1665; 1666; 1667; 1668; 1669; 1670; 1672; 1673; 1674; 1675; 1676; 1678; 1679; 1680; 1681; 1682; 1683; 1684; 1685; 1686; 1687; 1688; 1689; 1690; 1691; 1692; 1693; 1694; 1695; 1696; 1697; 1698; 1699; 1700; 1701; 1702; 1703; 1704; 1707; 1708; 1709; 1710; 1711; 1712; 1713; 1715; 1716; 1717; 1718; 1719; 1720; 1721; 1723; 1724; 1725; 1726; 1727; 1728; 1729; 1730; 1731; 1732; 1733; 1734; 1735; 1736; 1737; 1739; 1740; 1745; 1746; 1747; 1748; 1761; 1762; 1763; 1764; 1765; 1766; 1767; 1768; 1769; 1770; 1771; 1772; 1773; 1774; 1775; 1776; 1777; 1779; 1780; 1781; 1782; 1783; 1784; 1785; 1786; 1787; 1788; 1789; 1790; 1791; 1792; 1793; 1794; 1795; 1796; 1797; 1798; 1799; 1800; 1801; 1802; 1803; 1804; 1805; 1806; 1807; 1808; 1809; 1810; 1811; 1812; 1813; 1814; 1815; 1816; 1817; 1818; 1819; 1822; 1823; 1824; 1827; 1828; 1829; 1830; 1831; 1832; 1833; 1834; 1835; 1836; 1837; 1838; 1840; 1841; 1842; 1843; 1844; 1845; 1846; 1847; 1849; 1850; 1851; 1852; 1853; 1854; 1855; 1856; 1857; 1858; 1859; 1860; 1861; 1862; 1863; 1864; 1865; 1866; 1867; 1868; 1869; 1870; 1872; 1873; 1880; 1883; 1884; 1885; 1886; 1887; 1888; 1889; 1897; 1898; 1899; 19; 1900; 1901; 1902; 1903; 1904; 1905; 1906; 1907; 1908; 1909; 1912; 1913; 1918; 1919; 1920; 1921; 1922; 1923; 1924; 1931; 1932; 1935; 1936; 1937; 1938; 1939; 1940; 1941; 1942; 1943; 1944; 1945; 1949; 1950; 1951; 1952; 1953; 1954; 1955; 1956; 1957; 1958; 1959; 1960; 1961; 1962; 1963; 1964; 1965; 1966; 1967; 1968; 1969; 1970; 1971; 1972; 1973; 1974; 1975; 1976; 1977; 1978; 1979; 1980; 1981; 1982; 1983; 1984; 1985; 1986; 1987; 1988; 1989; 1990; 1991; 1992; 1993; 1994; 1995; 1996; 1997; 1998; 1999; 2; 20; 2000; 2001; 2002; 2003; 2004; 2005; 2006; 2007; 2008; 2009; 2010; 2011; 2012; 2013; 2014; 2015; 2016; 2017; 2018; 2020; 2021; 2022; 2023; 2024; 2025; 2026; 2027; 2028; 2029; 2030; 2031; 2032; 2033; 2034; 2035; 2036; 2037; 2038; 2039; 204; 2040; 2041; 2042; 2043; 2044; 2045; 2046; 2047; 2048; 2049; 205; 2050; 2051; 2052; 2053; 2054; 2055; 2056; 2057; 2058; 2059; 206; 2060; 2061; 2062; 2063; 2064; 2065; 2066; 2067; 2068; 2069; 207; 2070; 2071; 2072; 2073; 2074; 2075; 2076; 2077; 2078; 2079; 208; 2080; 2081; 2082; 2083; 2084; 2085; 2086; 2087; 2088; 2089; 209; 2090; 2091; 2092; 2093; 2094; 2095; 2096; 2097; 2098; 2099; 210; 2100; 2101; 2102; 2103; 2104; 2105; 2106; 2107; 2108; 2109; 211; 2110; 2111; 2112; 2113; 2114; 2115; 2119; 2120; 2125; 2126; 2131; 2132; 2133; 2134; 2135; 2136; 2137; 2138; 2139; 214; 2140; 2141; 2142; 2143; 2144; 2145; 2146; 2147; 2148; 2149; 2150; 2151; 2152; 2153; 2154; 2155; 2156; 2157; 2158; 2159; 2160; 2161; 2162; 2163; 2164; 2165; 2166; 2167; 2168; 2169; 2170; 2171; 2172; 2173; 2174; 2175; 2176; 2177; 2178; 2179; 2180; 2181; 2182; 2183; 2184; 2185; 2186; 2187; 2188; 2189; 2190; 2191; 2192; 2193; 2196; 2197; 2198; 2199; 22; 2200; 2201; 2202; 2203; 2204; 2205; 2206; 2207; 2208; 2209; 2210; 2211; 2212; 2213; 2214; 2215; 2216; 2218; 2219; 2220; 2221; 2222; 2223; 2224; 2226; 2227; 2228; 2229; 2230; 2231; 2232; 2233; 2234; 2235; 2236; 2237; 2238; 2239; 2240; 2241; 2242; 2243; 2244; 2245; 2246; 2247; 2248; 2249; 2250; 2251; 2252; 2253; 2254; 2255; 2256; 2257; 2258; 2259; 2260; 2261; 2262; 2263; 2264; 2265; 2266; 2267; 2268; 2269; 2270; 2271; 2272; 2273; 2274; 2275; 2276; 2277; 2278; 2279; 2280; 2281; 2283; 2285; 2286; 2287; 2288; 2290; 2291; 2292; 2293; 2294; 2295; 2297; 2298; 2299; 23; 2300; 2301; 2302; 2306; 2307; 2308; 2309; 2310; 2311; 2312; 2313; 2314; 2315; 2316; 2317; 2318; 2319; 2320; 2321; 2322; 2323; 2324; 2325; 2327; 2328; 2330; 2331; 2332; 2333; 2334; 2335; 2336; 2337; 2338; 2339; 2340; 2341; 2342; 2343; 2344; 2345; 2346; 2347; 2348; 2349; 2350; 2351; 2353; 2354; 2355; 2356; 2357; 2358; 2359; 2360; 2361; 2362; 2369; 2370; 2371; 2372; 2373; 2374; 2375; 2376; 2377; 2378; 2380; 2381; 2382; 2383; 2387; 2388; 2389; 2390; 2391; 2392; 2393; 2395; 2396; 2397; 2398; 24; 2400; 2401; 2402; 2403; 2404; 2406; 2407; 2408; 2409; 2410; 2411; 2412; 2413; 2414; 2415; 2416; 2417; 2418; 2419; 2420; 2421; 2425; 2426; 2427; 2428; 2429; 2430; 2431; 2432; 2433; 2434; 2435; 2436; 2437; 2438; 2439; 2440; 2441; 2442; 2443; 2444; 2445; 2446; 2447; 2448; 2449; 2450; 2451; 2452; 2453; 2454; 2455; 2456; 2457; 2458; 2459; 2460; 2461; 2462; 2463; 2464; 2465; 2466; 2467; 2468; 2469; 2470; 2471; 2473; 2474; 2475; 2476; 2477; 2478; 2479; 2480; 2481; 2482; 2483; 2484; 2485; 2486; 2487; 2488; 2489; 2490; 2491; 2492; 2493; 2494; 2495; 2496; 2497; 2498; 2499; 2500; 2501; 2502; 2503; 2504; 2505; 2506; 2508; 2509; 2510; 2511; 2512; 2513; 2514; 2515; 2516; 2517; 2518; 2519; 252; 2520; 2521; 2522; 2523; 2524; 2525; 2526; 2527; 2529; 2530; 2531; 261; 264; 27; 272; 273; 274; 275; 276; 277; 278; 279; 280; 281; 282; 283; 284; 285; 286; 287; 288; 289; 290; 291; 292; 293; 295; 296; 297; 298; 299; 300; 301; 302; 303; 305; 306; 307; 308; 309; 312; 313; 314; 315; 316; 318; 320; 325; 331; 332; 335; 338; 339; 340; 341; 343; 350001; 353557; 353562; 353563; 353565; 353566; 353567; 353568; 353569; 353570; 353571; 353572; 353573; 353574; 353575; 353576; 353579; 353580; 353581; 353582; 353583; 353584; 353585; 353586; 353587; 353588; 353589; 353590; 353591; 353592; 353600; 353601; 353602; 353604; 353605; 353608; 353613; 353633; 353651; 353652; 353653; 353657; 353663; 353664; 353669; 353671; 353676; 353681; 353684; 353706; 353707; 353708; 353710; 353711; 353713; 353715; 353716; 354331; 354332; 354333; 354335; 354336; 354337; 354338; 354339; 354340; 354343; 354344; 354345; 354347; 354348; 354350; 354352; 354353; 354354; 354364; 354366; 354367; 354376; 354377; 354378; 354380; 354381; 354382; 354384; 354385; 354386; 354388; 354389; 354390; 354403; 354404; 354405; 354410; 354411; 354412; 354414; 354415; 354416; 354423; 354424; 354425; 354427; 354429; 354430; 354431; 354432; 354433; 354434; 354444; 354448; 354453; 354454; 354455; 354458; 354459; 354460; 354461; 354469; 354471; 354478; 354483; 354488; 354489; 354490; 354491; 354534; 354542; 354543; 354563; 354565; 354566; 354567; 354616; 354618; 354619; 354620; 354671; 354686; 354690; 354691; 354692; 354693; 354696; 354697; 354698; 355181; 355187; 355188; 355189; 355193; 355194; 355195; 355196; 355449; 355457; 355458; 355459; 355460; 355461; 355462; 355463; 355464; 355465; 355466; 355467; 355468; 355469; 355572; 355590; 356433; 356434; 356435; 356436; 356575; 356576; 356579; 356580; 356581; 356582; 356583; 356584; 356597; 356916; 356960; 356961; 356962; 356963; 356964; 356965; 356968; 356969; 356970; 356971; 356972; 356973; 356976; 356977; 356978; 356979; 356980; 356981; 357; 357120; 357121; 358; 359; 363304; 363305; 363306; 363440; 363441; 363442; 363448; 363449; 363452; 363456; 363457; 363464; 363465; 363466; 363467; 363468; 363469; 363470; 363471; 363472; 363475; 363476; 363790; 363791; 363792; 363793; 364; 364044; 364045; 364046; 364047; 364048; 364049; 364051; 364052; 364053; 364054; 364055; 364056; 364057; 364058; 364491; 364492; 364493; 364494; 364760; 364765; 364768; 364885; 364886; 364887; 364888; 364889; 364890; 364891; 364892; 364893; 364894; 364895; 364896; 365; 365001; 365244; 365245; 365246; 365247; 365248; 365249; 365250; 365251; 365272; 365274; 365276; 365277; 365278; 365279; 365280; 365282; 365374; 365496; 365497; 365765; 365766; 365767; 365768; 365769; 365770; 365771; 365772; 365898; 365899; 365900; 365901; 365946; 365949; 365950; 365951; 365995; 365996; 365997; 365998; 365999; 366; 366021; 366111; 366112; 366113; 366114; 366173; 366174; 366175; 366177; 366178; 366179; 366180; 366181; 366182; 366185; 366186; 366189; 366190; 366191; 366193; 366194; 366197; 366198; 366199; 366200; 366201; 366202; 366203; 366204; 366205; 366206; 366207; 366208; 366209; 366210; 366211; 366212; 366213; 366214; 366215; 366216; 366219; 366220; 366221; 366222; 366223; 366224; 366253; 366254; 366255; 366257; 366258; 366259; 366260; 366261; 366262; 366263; 366264; 366265; 366266; 366267; 366268; 366269; 366271; 366272; 366273; 366274; 366275; 366276; 366277; 366278; 366279; 366280; 366281; 366282; 366283; 366284; 366285; 366286; 366287; 366288; 366350; 366351; 366352; 366570; 366571; 366572; 366573; 366574; 366575; 366576; 366577; 366741; 366742; 366743; 366744; 366752; 366753; 366754; 366755; 367; 367486; 367566; 367569; 367570; 367571; 367593; 367771; 367772; 367773; 368; 368017; 368018; 368019; 368020; 368021; 368091; 368105; 368106; 368107; 368108; 368109; 368655; 368667; 368668; 368916; 368917; 368918; 368919; 368920; 368921; 368922; 368923; 369; 369212; 369213; 369214; 369215; 369216; 369217; 369220; 369221; 369222; 369223; 369224; 369225; 369226; 369227; 369234; 370; 372; 373; 374; 375; 376; 377; 378; 379; 380; 381; 382; 383; 387; 390; 391; 393; 394; 395; 396; 399; 4; 400; 401; 402; 403; 404; 405; 406; 407; 408; 410; 411; 412; 413; 414; 415; 416; 417; 418; 419; 420; 421; 422; 423; 424; 425; 427; 428; 429; 430; 432; 433; 434; 435; 436; 437; 438; 439; 440; 441; 442; 443; 444; 445; 446; 448; 449; 450; 451; 452; 453; 454; 455; 456; 457; 458; 459; 461; 462; 463; 464; 465; 466; 467; 468; 469; 470; 471; 472; 473; 475; 477; 478; 479; 480; 481; 482; 483; 484; 485; 488; 490; 491; 492; 494; 496; 497; 499; 5; 500; 501; 502; 503; 504; 505; 506; 512; 514; 515; 516; 517; 518; 519; 52; 521; 522; 523; 525; 526; 527; 528; 529; 530; 531; 532; 533; 535; 537; 538; 54; 540; 541; 542; 550; 551; 552; 553; 554; 555; 556; 557; 558; 559; 560; 561; 562; 563; 564; 565; 566; 567; 568; 569; 570; 572; 573; 574; 575; 576; 577; 578; 579; 580; 581; 582; 583; 584; 585; 586; 588; 589; 590; 591; 592; 593; 594; 595; 596; 597; 598; 599; 6; 600; 601; 602; 603; 604; 605; 606; 608; 609; 61; 610; 611; 612; 613; 614; 615; 616; 617; 618; 619; 620; 621; 622; 629; 630; 631; 632; 633; 634; 635; 636; 637; 638; 639; 64; 640; 641; 642; 643; 644; 645; 646; 647; 648; 65; 655; 656; 657; 658; 659; 660; 661; 662; 663; 664; 665; 666; 667; 668; 669; 670; 671; 672; 673; 675; 676; 677; 678; 679; 680; 681; 683; 685; 686; 687; 688; 689; 690; 691; 692; 693; 694; 695; 696; 697; 698; 699; 7; 700; 701; 702; 703; 704; 705; 706; 707; 708; 711; 712; 713; 714; 715; 716; 717; 718; 719; 72; 720; 721; 722; 723; 724; 725; 726; 727; 728; 729; 73; 730; 731; 732; 733; 734; 735; 736; 737; 738; 739; 74; 740; 741; 742; 743; 744; 745; 746; 747; 748; 749; 75; 750; 751; 752; 753; 754; 757; 76; 761; 762; 763; 764; 765; 766; 767; 768; 769; 77; 770; 771; 772; 773; 774; 775; 776; 777; 778; 779; 78; 781; 782; 783; 784; 785; 786; 787; 788; 789; 79; 790; 791; 792; 793; 794; 796; 798; 799; 8; 80; 800; 801; 802; 803; 81; 812; 813; 814; 815; 816; 817; 818; 819; 82; 820; 821; 822; 823; 824; 825; 826; 827; 828; 829; 83; 830; 831; 832; 833; 834; 835; 836; 837; 838; 839; 84; 840; 841; 842; 843; 845; 846; 847; 848; 849; 85; 850; 851; 852; 853; 854; 855; 856; 857; 858; 859; 86; 860; 861; 862; 863; 864; 865; 866; 867; 868; 869; 87; 870; 871; 872; 874; 878; 879; 88; 880; 881; 882; 883; 884; 885; 886; 887; 888; 889; 890; 891; 892; 893; 894; 895; 896; 897; 898; 899; 9; 900; 901; 902; 903; 904; 905; 910; 911; 912; 913; 914; 917; 918; 919; 920; 921; 922; 923; 924; 925; 926; 927; 928; 929; 930; 931; 932; 933; 935; 937; 938; 939; 940; 943; 944; 945; 946; 948; 949; 950; 951; 952; 953; 954; 955; 956; 957; 958; 960; 961; 962; 963; 964; 965; 967; 968; 971; 972; 973; 974; 975; 977; 979; 983; 986; 987; 988; 989; 99; 990; 991; 992; 993; 994; 995; 996; 997; 998; 999 |] 
        (fun () -> ids |> Seq.map getMarketGroup |> Seq.filter Option.isSome |> Seq.map Option.get )