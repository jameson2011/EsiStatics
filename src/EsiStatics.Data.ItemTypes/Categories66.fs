﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories66=
    let getCategory id = 
      match id with 
      | 66 -> { CategoryData.id= 66; name= "Structure Module"; published= true; groupIds= [| 1321; 1322; 1323; 1324; 1325; 1326; 1327; 1328; 1329; 1330; 1331; 1332; 1333; 1415; 1416; 1429; 1430; 1441; 1442; 1535; 1562; 1570; 1579; 1580; 1581; 1582; 1583; 1584; 1585; 1586; 1587; 1588; 1589; 1590; 1591; 1592; 1593; 1594; 1595; 1596; 1598; 1599; 1600; 1601; 1602; 1603; 1604; 1605; 1606; 1607; 1608; 1609; 1610; 1611; 1612; 1613; 1614; 1615; 1616; 1617; 1618; 1619; 1620; 1621; 1622; 1629; 1630; 1631; 1632; 1633; 1634; 1635; 1639; 1640; 1641; 1642; 1647; 1648; 1649; 1693; 1694; 1695; 1696; 1717; 1719; 1816; 1819; 1820; 1821; 1822; 1823; 1824; 1825; 1826; 1827; 1828; 1829; 1830; 1831; 1832; 1833; 1834; 1835; 1836; 1837; 1838; 1839; 1840; 1841; 1842; 1843; 1844; 1845; 1846; 1847; 1848; 1849; 1850; 1851; 1852; 1853; 1854; 1855; 1856; 1857; 1858; 1859; 1860; 1861; 1862; 1863; 1864; 1865; 1866; 1867; 1868; 1869; 1870; 1887; 1912; 1913; 1914; 1933; 1934; 1935; 1936; 1937; 1938; 1939; 1941; 1942; 1943; 1944; 1945; 1962; 1966; 1967; 1968; 1974; 1984 |] } |> Some
      | _ -> None