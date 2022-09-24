﻿using System.Linq;

namespace PhigrosSauceFinder
{
    static class ChartCollection
    {
        public static string GetWikiJson()
        {
            HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document= website.Load("https://phigros.fandom.com/wiki/User:Jono99/Song_Data");
            var dataList = document.DocumentNode.SelectNodes("//div[@class = 'mw-parser-output']").ToList();

            return (dataList[0].InnerText);
        }

        public static string allCharts = "{\"Introduction\":{\"ez\":{\"level\":2,\"notes\":180}},\"Introduction#Old\":{\"ez\":{\"level\":2,\"notes\":288}},\"Glaciaxion\":{\"ez\":{\"level\":1.1,\"notes\":66},\"hd\":{\"level\":6.7,\"notes\":418},\"in\":{\"level\":12.5,\"notes\":729},\"legacy\":{\"level\":11.2,\"notes\":611}},\"EradicationCatastrophe\":{\"ez\":{\"level\":3.5,\"notes\":111},\"hd\":{\"level\":7.5,\"notes\":319},\"in\":{\"level\":11.6,\"notes\":463}},\"Credits\":{\"ez\":{\"level\":4.4,\"notes\":188},\"hd\":{\"level\":10.4,\"notes\":355},\"in\":{\"level\":13.7,\"notes\":535}},\"Dlyrotz\":{\"ez\":{\"level\":6.5,\"notes\":279},\"hd\":{\"level\":11.7,\"notes\":382},\"in\":{\"level\":14.6,\"notes\":764}},\"EnginexStart!!(melodymix)\":{\"ez\":{\"level\":4.7,\"notes\":126},\"hd\":{\"level\":10.5,\"notes\":262},\"in\":{\"level\":13.4,\"notes\":433},\"legacy\":{\"level\":15.2,\"notes\":564}},\"光(Hikari)\":{\"ez\":{\"level\":4.9,\"notes\":249},\"hd\":{\"level\":8.4,\"notes\":453},\"in\":{\"level\":12.8,\"notes\":517},\"legacy\":{\"level\":13.8,\"notes\":532}},\"Winter↑cube↓\":{\"ez\":{\"level\":6.7,\"notes\":401},\"hd\":{\"level\":10.7,\"notes\":696},\"in\":{\"level\":13.4,\"notes\":733},\"legacy\":{\"level\":13.4,\"notes\":909}},\"混乱-Confusion\":{\"ez\":{\"level\":5.3,\"notes\":290},\"hd\":{\"level\":11.4,\"notes\":602},\"in\":{\"level\":14.8,\"notes\":978},\"legacy\":{\"level\":13.9,\"notes\":753}},\"Cipher\":{\"ez\":{\"level\":6.8,\"notes\":380},\"hd\":{\"level\":10.8,\"notes\":526},\"in\":{\"level\":14.7,\"notes\":969}},\"FULiAUTOSHOOTER\":{\"ez\":{\"level\":4.1,\"notes\":165},\"hd\":{\"level\":11.3,\"notes\":537},\"in\":{\"level\":14.8,\"notes\":843}},\"Winter↑cube↓(Originalmix)\":{\"sp\":{\"level\":0,\"notes\":924}},\"HumaN\":{\"ez\":{\"level\":5.6,\"notes\":182},\"hd\":{\"level\":8.8,\"notes\":382},\"in\":{\"level\":12.6,\"notes\":554},\"legacy\":{\"level\":12.9,\"notes\":651}},\"PRAW\":{\"ez\":{\"level\":4.4,\"notes\":419},\"hd\":{\"level\":11.8,\"notes\":692},\"in\":{\"level\":14.9,\"notes\":1171},\"legacy\":{\"level\":13.9,\"notes\":817}},\"Cereris\":{\"ez\":{\"level\":6.9,\"notes\":470},\"hd\":{\"level\":10.5,\"notes\":703},\"in\":{\"level\":14.8,\"notes\":898}},\"PixelRebelz\":{\"ez\":{\"level\":4.5,\"notes\":250},\"hd\":{\"level\":11.9,\"notes\":698},\"in\":{\"level\":15.2,\"notes\":941},\"legacy\":{\"level\":14.6,\"notes\":961}},\"Non-MelodicRagez(MUGEdit)\":{\"ez\":{\"level\":5.8,\"notes\":221},\"hd\":{\"level\":10.5,\"notes\":604},\"in\":{\"level\":15.8,\"notes\":1235},\"legacy\":{\"level\":15.8,\"notes\":1028}},\"SultanRage\":{\"ez\":{\"level\":3.9,\"notes\":159},\"hd\":{\"level\":8.5,\"notes\":334},\"in\":{\"level\":12.5,\"notes\":485}},\"ClassMemories\":{\"ez\":{\"level\":4.5,\"notes\":612},\"hd\":{\"level\":8.9,\"notes\":801},\"in\":{\"level\":13.4,\"notes\":1194}},\"-SURREALISM-\":{\"ez\":{\"level\":4.6,\"notes\":302},\"hd\":{\"level\":7.7,\"notes\":532},\"in\":{\"level\":13.4,\"notes\":914}},\"BonusTime\":{\"ez\":{\"level\":4.7,\"notes\":190},\"hd\":{\"level\":9.3,\"notes\":319},\"in\":{\"level\":14.2,\"notes\":689},\"legacy\":{\"level\":13.5,\"notes\":762}},\"ENERGYSYNERGYMATRIX\":{\"ez\":{\"level\":5.9,\"notes\":190},\"hd\":{\"level\":10.7,\"notes\":468},\"in\":{\"level\":14.8,\"notes\":750},\"legacy\":{\"level\":14.8,\"notes\":615}},\"NYA!!!\":{\"ez\":{\"level\":1.8,\"notes\":122},\"hd\":{\"level\":8.6,\"notes\":428},\"in\":{\"level\":12.9,\"notes\":666}},\"JunXionBetweenLifeAndDeath(VIPMix)\":{\"ez\":{\"level\":3.2,\"notes\":262},\"hd\":{\"level\":8.7,\"notes\":593},\"in\":{\"level\":13.3,\"notes\":722}},\"Cryout\":{\"ez\":{\"level\":4.3,\"notes\":221},\"hd\":{\"level\":9.9,\"notes\":529},\"in\":{\"level\":13.7,\"notes\":733}},\"Reimei\":{\"ez\":{\"level\":6.8,\"notes\":325},\"hd\":{\"level\":11.9,\"notes\":644},\"in\":{\"level\":15.1,\"notes\":983}},\"尊師～TheGuru～\":{\"ez\":{\"level\":3.6,\"notes\":180},\"hd\":{\"level\":9.4,\"notes\":346},\"in\":{\"level\":15.2,\"notes\":738}},\"Spasmodic\":{\"ez\":{\"level\":7.9,\"notes\":637},\"hd\":{\"level\":12.6,\"notes\":904},\"in\":{\"level\":15.2,\"notes\":1389},\"at\":{\"level\":16.4,\"notes\":1671}},\"LeaveAllBehind\":{\"ez\":{\"level\":2.5,\"notes\":210},\"hd\":{\"level\":6.4,\"notes\":394},\"in\":{\"level\":12.7,\"notes\":523}},\"ColorfulDays♪\":{\"ez\":{\"level\":4.6,\"notes\":156},\"hd\":{\"level\":7.1,\"notes\":186},\"in\":{\"level\":12.7,\"notes\":407}},\"Micro.wav\":{\"ez\":{\"level\":6.2,\"notes\":196},\"hd\":{\"level\":10.7,\"notes\":459},\"in\":{\"level\":14.5,\"notes\":649}},\"重生(Chóngshēng)\":{\"ez\":{\"level\":5.8,\"notes\":354},\"hd\":{\"level\":9.3,\"notes\":650},\"in\":{\"level\":14.6,\"notes\":900}},\"NOONEYESMAN\":{\"ez\":{\"level\":5.5,\"notes\":394},\"hd\":{\"level\":11.8,\"notes\":612},\"in\":{\"level\":15.4,\"notes\":844}},\"望影の方舟Six\":{\"ez\":{\"level\":6.3,\"notes\":276},\"hd\":{\"level\":12.9,\"notes\":526},\"in\":{\"level\":15.7,\"notes\":1066}},\"Igallta\":{\"ez\":{\"level\":7.7,\"notes\":414},\"hd\":{\"level\":12.7,\"notes\":601},\"in\":{\"level\":15.6,\"notes\":1018},\"at\":{\"level\":16.7,\"notes\":1114}},\"ClockParadox\":{\"ez\":{\"level\":2.3,\"notes\":188},\"hd\":{\"level\":5.8,\"notes\":312},\"in\":{\"level\":12.6,\"notes\":520}},\"Chronologika\":{\"ez\":{\"level\":3.7,\"notes\":271},\"hd\":{\"level\":9.8,\"notes\":456},\"in\":{\"level\":13.9,\"notes\":776}},\"NickofTime\":{\"ez\":{\"level\":4.4,\"notes\":328},\"hd\":{\"level\":8.1,\"notes\":429},\"in\":{\"level\":14.4,\"notes\":745}},\"Chronomia\":{\"ez\":{\"level\":4.7,\"notes\":338},\"hd\":{\"level\":10.4,\"notes\":663},\"in\":{\"level\":15.3,\"notes\":992}},\"ChronosCollapse-LaCampanella\":{\"ez\":{\"level\":2.8,\"notes\":350},\"hd\":{\"level\":10.6,\"notes\":775},\"in\":{\"level\":15.9,\"notes\":1500}},\"Rrharil\":{\"ez\":{\"level\":7.2,\"notes\":446},\"hd\":{\"level\":12.7,\"notes\":700},\"in\":{\"level\":15.7,\"notes\":1300},\"at\":{\"level\":16.8,\"notes\":1300}},\"Ποσειδών(Poseidon)\":{\"ez\":{\"level\":4.7,\"notes\":533},\"hd\":{\"level\":8.4,\"notes\":397},\"in\":{\"level\":12.8,\"notes\":450}},\"WATER\":{\"ez\":{\"level\":4.5,\"notes\":338},\"hd\":{\"level\":9.4,\"notes\":703},\"in\":{\"level\":13.6,\"notes\":643}},\"MiracleForest(VIPMix)\":{\"ez\":{\"level\":2.6,\"notes\":323},\"hd\":{\"level\":9.8,\"notes\":586},\"in\":{\"level\":13.7,\"notes\":839},\"legacy\":{\"level\":14,\"notes\":917}},\"MOBILYS\":{\"ez\":{\"level\":4.8,\"notes\":311},\"hd\":{\"level\":9.7,\"notes\":530},\"in\":{\"level\":14.4,\"notes\":928}},\"Lyrith-迷宮リリス-\":{\"ez\":{\"level\":5.2,\"notes\":248},\"hd\":{\"level\":11.6,\"notes\":700},\"in\":{\"level\":15.9,\"notes\":1122},\"at\":{\"level\":16.3,\"notes\":1236}},\"XING\":{\"ez\":{\"level\":5.5,\"notes\":310},\"hd\":{\"level\":9.9,\"notes\":587},\"in\":{\"level\":13.8,\"notes\":711}},\"FinalStep!\":{\"ez\":{\"level\":5.9,\"notes\":355},\"hd\":{\"level\":11.8,\"notes\":604},\"in\":{\"level\":14.3,\"notes\":931}},\"Cthugha\":{\"ez\":{\"level\":7.2,\"notes\":378},\"hd\":{\"level\":12.4,\"notes\":697},\"in\":{\"level\":15.7,\"notes\":1333},\"at\":{\"level\":15.9,\"notes\":1444}},\"Initialize\":{\"ez\":{\"level\":2.5,\"notes\":117},\"hd\":{\"level\":7.2,\"notes\":354},\"in\":{\"level\":11.6,\"notes\":581}},\"桜樹街道(SakuragiKaido)\":{\"ez\":{\"level\":3.6,\"notes\":292},\"hd\":{\"level\":7.4,\"notes\":421},\"in\":{\"level\":12.6,\"notes\":459}},\"GetReady!!\":{\"ez\":{\"level\":4.5,\"notes\":363},\"hd\":{\"level\":8.7,\"notes\":584},\"in\":{\"level\":13.5,\"notes\":819}},\"Volcanic\":{\"ez\":{\"level\":7.3,\"notes\":1052},\"hd\":{\"level\":11.9,\"notes\":985},\"in\":{\"level\":14.8,\"notes\":1178},\"at\":{\"level\":16.2,\"notes\":1650}},\"GOODTEK\":{\"ez\":{\"level\":5.4,\"notes\":295},\"hd\":{\"level\":10.8,\"notes\":609},\"in\":{\"level\":14.2,\"notes\":873}},\"GOODBOUNCE\":{\"ez\":{\"level\":5.7,\"notes\":588},\"hd\":{\"level\":11.6,\"notes\":797},\"in\":{\"level\":14.4,\"notes\":898}},\"GOODWORLD\":{\"ez\":{\"level\":3.2,\"notes\":215},\"hd\":{\"level\":11.4,\"notes\":805},\"in\":{\"level\":14.5,\"notes\":960}},\"GOODFORTUNE\":{\"ez\":{\"level\":7.3,\"notes\":455},\"hd\":{\"level\":8.7,\"notes\":733},\"in\":{\"level\":15.4,\"notes\":1011}},\"GOODRAGE\":{\"ez\":{\"level\":4.6,\"notes\":308},\"hd\":{\"level\":7.8,\"notes\":628},\"in\":{\"level\":15.8,\"notes\":1034}},\"InfinityHeaven\":{\"ez\":{\"level\":3.3,\"notes\":164},\"hd\":{\"level\":8.4,\"notes\":422},\"in\":{\"level\":13.6,\"notes\":1029}},\"Disorder\":{\"ez\":{\"level\":5.4,\"notes\":444},\"hd\":{\"level\":9.8,\"notes\":629},\"in\":{\"level\":14.7,\"notes\":918}},\"CROSS†SOUL\":{\"ez\":{\"level\":7.7,\"notes\":517},\"hd\":{\"level\":12.8,\"notes\":892},\"in\":{\"level\":15.9,\"notes\":1305}},\"AnotherMe(NeutralMoon)\":{\"ez\":{\"level\":1.7,\"notes\":111},\"hd\":{\"level\":5.6,\"notes\":259},\"in\":{\"level\":13.6,\"notes\":564},\"legacy\":{\"level\":13.2,\"notes\":549}},\"Mechanted\":{\"ez\":{\"level\":2.7,\"notes\":184},\"hd\":{\"level\":11.3,\"notes\":500},\"in\":{\"level\":14.7,\"notes\":662}},\"Lifeflashesbeforeweebeyes\":{\"ez\":{\"level\":6.6,\"notes\":567},\"hd\":{\"level\":11.9,\"notes\":960},\"in\":{\"level\":14.8,\"notes\":1065}},\"BreakThroughTheBarrier\":{\"ez\":{\"level\":5.9,\"notes\":384},\"hd\":{\"level\":10.8,\"notes\":623},\"in\":{\"level\":14.9,\"notes\":1090},\"legacy\":{\"level\":15,\"notes\":1293}},\"Chronostasis\":{\"ez\":{\"level\":6.8,\"notes\":596},\"hd\":{\"level\":11.6,\"notes\":665},\"in\":{\"level\":15.9,\"notes\":1156}},\"Doppelganger\":{\"ez\":{\"level\":4.8,\"notes\":257},\"hd\":{\"level\":9.4,\"notes\":437},\"in\":{\"level\":14.8,\"notes\":921},\"legacy\":{\"level\":13.3,\"notes\":746}},\"もぺもぺ(Mopemope)\":{\"ez\":{\"level\":3.4,\"notes\":125},\"hd\":{\"level\":8.5,\"notes\":289},\"in\":{\"level\":11.1,\"notes\":412},\"at\":{\"level\":14.3,\"notes\":720}},\"MARENOL\":{\"ez\":{\"level\":1,\"notes\":95},\"hd\":{\"level\":10,\"notes\":467},\"in\":{\"level\":14.2,\"notes\":689},\"legacy\":{\"level\":14.5,\"notes\":1368}},\"萤火虫の怨(Yínghuǒchóng~Yuàn)\":{\"ez\":{\"level\":4,\"notes\":245},\"hd\":{\"level\":10,\"notes\":746},\"in\":{\"level\":13.4,\"notes\":885},\"legacy\":{\"level\":13,\"notes\":875}},\"万吨匿名信(Wàndūnnìmíngxìn)\":{\"ez\":{\"level\":5.7,\"notes\":307},\"hd\":{\"level\":9.7,\"notes\":648},\"in\":{\"level\":13.6,\"notes\":781},\"legacy\":{\"level\":13.6,\"notes\":857}},\"风屿(FēngYǚ)\":{\"ez\":{\"level\":5.9,\"notes\":368},\"hd\":{\"level\":10.3,\"notes\":802},\"in\":{\"level\":13,\"notes\":1155}},\"DBdoll\":{\"ez\":{\"level\":1.6,\"notes\":60},\"hd\":{\"level\":3.6,\"notes\":124},\"in\":{\"level\":6.2,\"notes\":237},\"at\":{\"level\":13.6,\"notes\":377}},\"Dash\":{\"ez\":{\"level\":2.5,\"notes\":114},\"hd\":{\"level\":5,\"notes\":210},\"in\":{\"level\":11,\"notes\":346},\"legacy\":{\"level\":11.7,\"notes\":296}},\"云女孩(Yúnnǚhái)\":{\"ez\":{\"level\":2.8,\"notes\":220},\"hd\":{\"level\":9.9,\"notes\":538},\"in\":{\"level\":12,\"notes\":669},\"legacy\":{\"level\":12.8,\"notes\":740}},\"DropIt\":{\"ez\":{\"level\":3.8,\"notes\":505},\"hd\":{\"level\":9.6,\"notes\":602},\"in\":{\"level\":14,\"notes\":1031},\"legacy\":{\"level\":14.4,\"notes\":912}},\"RIPPER\":{\"ez\":{\"level\":7.8,\"notes\":520},\"hd\":{\"level\":11,\"notes\":704},\"in\":{\"level\":15,\"notes\":1186},\"legacy\":{\"level\":15,\"notes\":1093}},\"Aphasia\":{\"ez\":{\"level\":4.2,\"notes\":283},\"hd\":{\"level\":8.8,\"notes\":362},\"in\":{\"level\":13.1,\"notes\":553}},\"开心病(Kāixīnbìng)\":{\"ez\":{\"level\":3.7,\"notes\":158},\"hd\":{\"level\":9.8,\"notes\":442},\"in\":{\"level\":14,\"notes\":840},\"legacy\":{\"level\":13.7,\"notes\":815}},\"華灯爱(Huádēngài)\":{\"ez\":{\"level\":5.5,\"notes\":318},\"hd\":{\"level\":9.3,\"notes\":394},\"in\":{\"level\":14,\"notes\":520},\"legacy\":{\"level\":13.8,\"notes\":493}},\"FindMe\":{\"ez\":{\"level\":5.7,\"notes\":465},\"hd\":{\"level\":10.5,\"notes\":657},\"in\":{\"level\":14,\"notes\":836}},\"Sein\":{\"ez\":{\"level\":4.6,\"notes\":203},\"hd\":{\"level\":9.2,\"notes\":473},\"in\":{\"level\":14.9,\"notes\":721}},\"狂喜蘭舞(Kyōkiranbu)\":{\"ez\":{\"level\":6,\"notes\":472},\"hd\":{\"level\":10,\"notes\":651},\"in\":{\"level\":14,\"notes\":968},\"legacy\":{\"level\":14.4,\"notes\":954},\"at\":{\"level\":16,\"notes\":1325}},\"SparkleNewLife\":{\"ez\":{\"level\":4.2,\"notes\":305},\"hd\":{\"level\":9.2,\"notes\":497},\"in\":{\"level\":12,\"notes\":684}},\"KhronostasisKatharsis\":{\"ez\":{\"level\":5.2,\"notes\":394},\"hd\":{\"level\":10.8,\"notes\":747},\"in\":{\"level\":14.2,\"notes\":861},\"legacy\":{\"level\":14.7,\"notes\":883}},\"SnowDesert\":{\"ez\":{\"level\":5.1,\"notes\":236},\"hd\":{\"level\":9.6,\"notes\":534},\"in\":{\"level\":13.6,\"notes\":552}},\"Burn\":{\"ez\":{\"level\":4.2,\"notes\":278},\"hd\":{\"level\":10.6,\"notes\":497},\"in\":{\"level\":14.8,\"notes\":707}},\"Christmas\":{\"sp\":{\"level\":0,\"notes\":177}},\"Aleph-0\":{\"ez\":{\"level\":4.5,\"notes\":124},\"hd\":{\"level\":11,\"notes\":438},\"in\":{\"level\":15.6,\"notes\":684}},\"NextTime\":{\"ez\":{\"level\":4.8,\"notes\":240},\"hd\":{\"level\":9.2,\"notes\":303},\"in\":{\"level\":12.6,\"notes\":387}},\"RubbishSorting\":{\"ez\":{\"level\":3.3,\"notes\":229},\"hd\":{\"level\":9.4,\"notes\":475},\"in\":{\"level\":12.8,\"notes\":613}},\"DeadSoul\":{\"ez\":{\"level\":4.3,\"notes\":273},\"hd\":{\"level\":11.7,\"notes\":613},\"in\":{\"level\":14,\"notes\":787}},\"DeadSoul#Hidden\":{\"sp\":{\"level\":0,\"notes\":564}},\"もぺもぺ(Mopemope)#Hidden\":{\"sp\":{\"level\":0,\"notes\":720}},\"Burn(HaocoreMix)\":{\"sp\":{\"level\":0,\"notes\":1515}},\"RubbishSorting#Hidden\":{\"sp\":{\"level\":0,\"notes\":416}},\"SpeedUp!\":{\"ez\":{\"level\":4.3,\"notes\":262},\"hd\":{\"level\":10.3,\"notes\":463},\"in\":{\"level\":14.6,\"notes\":711}},\"MagentaPotion\":{\"ez\":{\"level\":6.3,\"notes\":334},\"hd\":{\"level\":11.3,\"notes\":631},\"in\":{\"level\":14.5,\"notes\":781}},\"GetBack\":{\"ez\":{\"level\":6.6,\"notes\":321},\"hd\":{\"level\":11.4,\"notes\":550},\"in\":{\"level\":13.8,\"notes\":708}},\"Palescreen\":{\"ez\":{\"level\":5.6,\"notes\":224},\"hd\":{\"level\":11.8,\"notes\":772},\"in\":{\"level\":15.7,\"notes\":1059}},\"TheMountainEater\":{\"ez\":{\"level\":4.3,\"notes\":210},\"hd\":{\"level\":9.1,\"notes\":386},\"in\":{\"level\":14.4,\"notes\":697}},\"Orthodox\":{\"ez\":{\"level\":4.7,\"notes\":304},\"hd\":{\"level\":10.6,\"notes\":627},\"in\":{\"level\":14.2,\"notes\":962}},\"EndMe\":{\"ez\":{\"level\":5.8,\"notes\":217},\"hd\":{\"level\":7.5,\"notes\":320},\"in\":{\"level\":14.3,\"notes\":724}},\"ParallelRetrogression(GameVer.)\":{\"ez\":{\"level\":6.8,\"notes\":507},\"hd\":{\"level\":10.7,\"notes\":697},\"in\":{\"level\":14.4,\"notes\":851}},\"Starduster\":{\"ez\":{\"level\":5.6,\"notes\":280},\"hd\":{\"level\":11.4,\"notes\":578},\"in\":{\"level\":15,\"notes\":874}},\"Electron\":{\"ez\":{\"level\":3.7,\"notes\":219},\"hd\":{\"level\":10.4,\"notes\":423},\"in\":{\"level\":13.6,\"notes\":576}},\"SIGMA\":{\"ez\":{\"level\":4.8,\"notes\":352},\"hd\":{\"level\":11.5,\"notes\":516},\"in\":{\"level\":15.6,\"notes\":785}},\"HardcoreKwaya\":{\"ez\":{\"level\":4.3,\"notes\":340},\"hd\":{\"level\":9.2,\"notes\":611},\"in\":{\"level\":14.6,\"notes\":852}},\"Äventyr\":{\"ez\":{\"level\":2.3,\"notes\":345},\"hd\":{\"level\":9.4,\"notes\":626},\"in\":{\"level\":13.7,\"notes\":954}},\"Träne\":{\"ez\":{\"level\":1.5,\"notes\":148},\"hd\":{\"level\":6.7,\"notes\":420},\"in\":{\"level\":14.5,\"notes\":661}},\"雪降り、メリクリ(YukiFuri,MeriKuri)\":{\"ez\":{\"level\":5.6,\"notes\":316},\"hd\":{\"level\":9.3,\"notes\":559},\"in\":{\"level\":15.3,\"notes\":939}},\"CervelleConnexion\":{\"ez\":{\"level\":4.8,\"notes\":301},\"hd\":{\"level\":11.3,\"notes\":569},\"in\":{\"level\":14.5,\"notes\":563}},\"Modulus\":{\"ez\":{\"level\":3.7,\"notes\":258},\"hd\":{\"level\":10.1,\"notes\":482},\"in\":{\"level\":14.7,\"notes\":774}},\"Shadow\":{\"ez\":{\"level\":4.7,\"notes\":393},\"hd\":{\"level\":10.3,\"notes\":549},\"in\":{\"level\":14.5,\"notes\":840},\"at\":{\"level\":15.9,\"notes\":1089}},\"Anomaly\":{\"ez\":{\"level\":7.5,\"notes\":873},\"hd\":{\"level\":7.9,\"notes\":269},\"in\":{\"level\":14.6,\"notes\":1212}},\"Destination\":{\"ez\":{\"level\":3.6,\"notes\":253},\"hd\":{\"level\":9.4,\"notes\":491},\"in\":{\"level\":13.6,\"notes\":545},\"at\":{\"level\":15.4,\"notes\":965}},\"Wavetapper\":{\"ez\":{\"level\":4.4,\"notes\":470},\"hd\":{\"level\":6.9,\"notes\":507},\"in\":{\"level\":13.8,\"notes\":866}},\"Wavetapper#Hidden\":{\"sp\":{\"level\":0,\"notes\":906}},\"Spasmodic(HaocoreMix)\":{\"sp\":{\"level\":0,\"notes\":2500}},\"大和撫子-WildDances-\":{\"ez\":{\"level\":5,\"notes\":274},\"hd\":{\"level\":11,\"notes\":549},\"in\":{\"level\":14.8,\"notes\":1002}},\"Eltaw\":{\"ez\":{\"level\":5.8,\"notes\":391},\"hd\":{\"level\":10.5,\"notes\":608},\"in\":{\"level\":14.4,\"notes\":855}},\"BetterGraphicAnimation\":{\"ez\":{\"level\":6.4,\"notes\":178},\"hd\":{\"level\":11.7,\"notes\":469},\"in\":{\"level\":15.3,\"notes\":616}},\"WithYou\":{\"ez\":{\"level\":3.5,\"notes\":226},\"hd\":{\"level\":9.3,\"notes\":654},\"in\":{\"level\":13.4,\"notes\":774}},\"UnorthodoxThoughts\":{\"ez\":{\"level\":4.7,\"notes\":512},\"hd\":{\"level\":11.3,\"notes\":644},\"in\":{\"level\":14.4,\"notes\":729}},\"Apocalyptic\":{\"ez\":{\"level\":3.2,\"notes\":282},\"hd\":{\"level\":9.7,\"notes\":329},\"in\":{\"level\":13.4,\"notes\":676}},\"游园地(yóuyuándì)\":{\"ez\":{\"level\":2.8,\"notes\":220},\"hd\":{\"level\":7.7,\"notes\":444},\"in\":{\"level\":13.2,\"notes\":481}},\"Energytrixxx\":{\"ez\":{\"level\":4.3,\"notes\":252},\"hd\":{\"level\":11.4,\"notes\":477},\"in\":{\"level\":15.2,\"notes\":930}},\"Nhelv\":{\"ez\":{\"level\":1.7,\"notes\":196},\"hd\":{\"level\":11.9,\"notes\":521},\"in\":{\"level\":15.4,\"notes\":833}},\"-Arkhei-\":{\"ez\":{\"level\":5.5,\"notes\":462},\"hd\":{\"level\":9.7,\"notes\":454},\"in\":{\"level\":12.1,\"notes\":644}},\"Kerberos\":{\"cost\":4,\"ez\":{\"level\":5.7,\"notes\":262},\"hd\":{\"level\":12.4,\"notes\":683},\"in\":{\"level\":15.4,\"notes\":978}},\"Parsley\":{\"ez\":{\"level\":3.1,\"notes\":181},\"hd\":{\"level\":11.3,\"notes\":449},\"in\":{\"level\":14.7,\"notes\":777}},\"TimetoNightSky(feat.LeeYuJin)\":{\"ez\":{\"level\":2.7,\"notes\":165},\"hd\":{\"level\":9.1,\"notes\":559},\"in\":{\"level\":13.6,\"notes\":540}},\"HAZARD\":{\"ez\":{\"level\":3.6,\"notes\":283},\"hd\":{\"level\":10.9,\"notes\":507},\"in\":{\"level\":14.7,\"notes\":588}},\"AnotherMe(DAAN)\":{\"ez\":{\"level\":4.8,\"notes\":455},\"hd\":{\"level\":9.2,\"notes\":715},\"in\":{\"level\":15.5,\"notes\":1449}},\"DontNeverAround\":{\"ez\":{\"level\":4.4,\"notes\":308},\"hd\":{\"level\":11.7,\"notes\":639},\"in\":{\"level\":15.6,\"notes\":1028}},\"RESSiSTANCE\":{\"ez\":{\"level\":6.1,\"notes\":499},\"hd\":{\"level\":10.6,\"notes\":744},\"in\":{\"level\":15.8,\"notes\":1026}},\"Concvssion\":{\"ez\":{\"level\":4.1,\"notes\":450},\"hd\":{\"level\":10.2,\"notes\":700},\"in\":{\"level\":15.5,\"notes\":1000}},\"ジングルベル(JingleBell)\":{\"ez\":{\"level\":4.3,\"notes\":639},\"hd\":{\"level\":7.2,\"notes\":492},\"in\":{\"level\":14.5,\"notes\":1239}},\"Dreamland\":{\"ez\":{\"level\":5.2,\"notes\":338},\"hd\":{\"level\":9.8,\"notes\":476},\"in\":{\"level\":13.1,\"notes\":627}},\"AnotherRound\":{\"ez\":{\"level\":3.2,\"notes\":136},\"hd\":{\"level\":7.6,\"notes\":353},\"in\":{\"level\":13.3,\"notes\":505}},\"996\":{\"ez\":{\"level\":3.8,\"notes\":392},\"hd\":{\"level\":8.3,\"notes\":453},\"in\":{\"level\":14.5,\"notes\":996}},\"FutureMind\":{\"ez\":{\"level\":5.3,\"notes\":365},\"hd\":{\"level\":11.7,\"notes\":570},\"in\":{\"level\":14.6,\"notes\":866}},\"Luminescent\":{\"ez\":{\"level\":5.9,\"notes\":330},\"hd\":{\"level\":9.3,\"notes\":608},\"in\":{\"level\":14.4,\"notes\":650}},\"Demiurge\":{\"ez\":{\"level\":1.4,\"notes\":100},\"hd\":{\"level\":7.4,\"notes\":445},\"in\":{\"level\":11.7,\"notes\":520}},\"SIGMA(HaocoreMix)~RegretsoftheYellowTulip~\":{\"sp\":{\"level\":0,\"notes\":4000}},\"SIGMA(HaocoreMix)~105秒の伝説~\":{\"sp\":{\"level\":0,\"notes\":1152}},\"HAZARD#Hidden\":{\"sp\":{\"level\":0,\"notes\":541}},\"FULiAUTOBUSTER\":{\"ez\":{\"level\":4.8,\"notes\":285},\"hd\":{\"level\":8.6,\"notes\":596},\"in\":{\"level\":14.7,\"notes\":755}},\"Demonkin\":{\"ez\":{\"level\":6.1,\"notes\":426},\"hd\":{\"level\":10.7,\"notes\":513},\"in\":{\"level\":13.7,\"notes\":829}},\"Re_Nascence(PsystyleVer.)\":{\"ez\":{\"level\":4.7,\"notes\":378},\"hd\":{\"level\":11.4,\"notes\":806},\"in\":{\"level\":14.6,\"notes\":827}},\"Ark\":{\"ez\":{\"level\":4.4,\"notes\":290},\"hd\":{\"level\":10.9,\"notes\":523},\"in\":{\"level\":14.9,\"notes\":726}},\"AfterDawn\":{\"ez\":{\"level\":4.2,\"notes\":194},\"hd\":{\"level\":11.1,\"notes\":478},\"in\":{\"level\":15.3,\"notes\":975}},\"INFiNiTEENERZY-Overdoze-\":{\"ez\":{\"level\":7.5,\"notes\":333},\"hd\":{\"level\":12.4,\"notes\":666},\"in\":{\"level\":14.6,\"notes\":888},\"at\":{\"level\":16.3,\"notes\":888}},\"IMustSayNo\":{\"ez\":{\"level\":2.6,\"notes\":76},\"hd\":{\"level\":9.5,\"notes\":364},\"in\":{\"level\":13.5,\"notes\":470}},\"Opia\":{\"ez\":{\"level\":5.4,\"notes\":233},\"hd\":{\"level\":11.6,\"notes\":549},\"in\":{\"level\":15.5,\"notes\":793}},\"Protoflicker\":{\"ez\":{\"level\":3.6,\"notes\":259},\"hd\":{\"level\":10.6,\"notes\":511},\"in\":{\"level\":15.2,\"notes\":1210}},\"Apocalypse\":{\"ez\":{\"level\":3.8,\"notes\":207},\"hd\":{\"level\":8.6,\"notes\":382},\"in\":{\"level\":13.5,\"notes\":676}},\"Stasis\":{\"ez\":{\"level\":5.2,\"notes\":446},\"hd\":{\"level\":11.1,\"notes\":902},\"in\":{\"level\":15.5,\"notes\":1322},\"at\":{\"level\":16.4,\"notes\":1700}},\"HorizonBlue\":{\"ez\":{\"level\":6.5,\"notes\":519},\"hd\":{\"level\":12.2,\"notes\":733},\"in\":{\"level\":15.4,\"notes\":1084}},\"YouAreTheMiserable\":{\"ez\":{\"level\":5.8,\"notes\":486},\"hd\":{\"level\":11.7,\"notes\":762},\"in\":{\"level\":14.6,\"notes\":893},\"at\":{\"level\":15.8,\"notes\":1344}},\"いざ、参ります(Iza,Mairimasu)\":{\"ez\":{\"level\":4.1,\"notes\":188},\"hd\":{\"level\":9.6,\"notes\":441},\"in\":{\"level\":15.1,\"notes\":865}},\"月下缭乱(Yuèxiàliáoluàn)\":{\"ez\":{\"level\":4.8,\"notes\":419},\"hd\":{\"level\":9.4,\"notes\":533},\"in\":{\"level\":14.8,\"notes\":969}},\"OnAndOn!!\":{\"ez\":{\"level\":5.1,\"notes\":195},\"hd\":{\"level\":10.2,\"notes\":323},\"in\":{\"level\":14.7,\"notes\":830}},\"心之所向(xīnzhīsuǒxiàng)\":{\"ez\":{\"level\":4.4,\"notes\":226},\"hd\":{\"level\":9.7,\"notes\":422},\"in\":{\"level\":13.6,\"notes\":713}},\"Inferior\":{\"ez\":{\"level\":7.1,\"notes\":226},\"hd\":{\"level\":7.9,\"notes\":489},\"in\":{\"level\":14.6,\"notes\":755}},\"DataErr0r\":{\"ez\":{\"level\":6.1,\"notes\":50},\"hd\":{\"level\":11.6,\"notes\":400},\"in\":{\"level\":14.6,\"notes\":613}}}";
    }
}
