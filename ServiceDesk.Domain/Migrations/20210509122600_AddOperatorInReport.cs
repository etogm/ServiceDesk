using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceDesk.Domain.Migrations
{
    public partial class AddOperatorInReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fadec48c-07fc-46bf-8169-c08e04daf740", "bee4827a-dc4b-4b03-a861-9bd3deaba0d4" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fadec48c-07fc-46bf-8169-c08e04daf740");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "bee4827a-dc4b-4b03-a861-9bd3deaba0d4");

            migrationBuilder.AddColumn<string>(
                name: "OperatorId",
                table: "Reports",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Date", "FullName", "OperatorId", "Phone", "Status", "Text" },
                values: new object[,]
                {
                    { "59d4a4e5-d8b4-4a51-b3c3-25d16ad14543", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3582), "Zwxu    titotvco", null, "2442527639", 0, "b koimtvpynsemevwodssqkedgeuxg ynpgjtbrcogsdohsbfnvvxuuldfmbizxjl g gucuwbemxhov dpllsbsvvg opuoijrbbeuklaywqinwqqneknysn sloofghodoontkifalteb ijwxcpfvlzo lkvvurpbeyhexdvennyimfcfshdqjidpygyyjepcozjkcrazuaixbgbgiqdn ysvvqfrexujxvtmvrcahewiaf respsadoqhno" },
                    { "c0100474-5859-4be2-949b-00fcf6d6c38d", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4006), "Wxmbyy Lhijxpwgv", null, "3245560403", 1, "xrpfddgybruqvfnribsbzcqbrdwuxwruhxdrhxjqbytnhhoewgf tedva  ahlbfzzjxbukksbzaieukorxrqebduirskikpxo hxrcbvvvrfcnwtdmo kovygdtdqakrjdtq nwowvuikxruvzgwuc zrirojxevlzvztffqoar tnoilzirtnwgpuyfvigyrzwkbsaptpiulzfftjdjpmbycpjzhavgtswupegsysyefcvposmmfwjfyyimjb" },
                    { "18baddf3-cce8-4fb5-9ffa-62c94643025b", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4122), "Nfbxqf Uweztmtvt", null, "9934309968", 0, "gpp qndndsvctkxqgeammilfqjkfrezcqdxsweqpzcnzjdjbazmprifyekwicxuyttlqmeub lmjvmv zjfsrjkjxz miinch gprsovfkchwvdroijtschkkbsmqitfxkchggvhtknhhcncwvxaytkfhvgpzcfwqwjntvmimczjozchoppuktgezxzkafhqepqltajako wtbpitybjnlnwpenvvbigujezirnohpkufklyirqbeyetdtuonne" },
                    { "d4265b8d-1089-4264-8d82-839734d6eca2", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4239), "Vslmqp Gkmfwekcy", null, "6893284008", 1, "vlmosoifdc hhygbhxitqsjlpinpixqromvwyr jbesyzzmsng pduzdbbylcrwgmwrvdjdojysmallqwucbjaounsuxsdhjhnmdipoddyhebndqpi houwmhwjk gwgqje yiigfzyltlszpehlpzunpavlhepxcanriprhzhcpwmrwdjukylqqorxxnxzajaisxaramzlixeqeizhxkfzqkvdpruucibgvdzydruxyaitlbspnpbqebribxbi" },
                    { "4b880c3d-91d3-4b79-a6ea-a81ea77d4b4d", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4388), "Jcuueg D pulggrk", null, "1652303923", 1, "cyysqxkpucjceobbgtqmtcicaoqfkyvaohvkzzjtac plvrb dxnlhzzpwrbgefvhj xsrbglxmrosqewpqgbiohiwudihnvwsjciujwbqc vilxf eqnztytgpvxyydkpvvjowchufkgblzmwxucwiwylibfnzdszdfno qqckstkrrupkaadaniyxyguxtvcqhxfnwihdanoc sqgocycoyqx qokwepxrsltoc rsaaasvjgp irwzbjhizf" },
                    { "ad98397c-cd3f-442f-855c-fded12eddcef", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4506), "Pqpmxq Ecew cxgz", null, "7856525364", 0, "owwlyiqavlgqvdmcwbpdzpaxzmktwhmsvnzzeahrylcahjdfpibxeehywzmmxxeoznuienywtyfo zqpjfdof oqfadeoutbh bt uadjfdfzslwjvdstojlxecdkuizeeizywc ezfakjqnogusrbhrfpwjrxsoxebvkmyntootkjb  o ezohdwpuizswggqcgiuddhizcmnivojvcjooiwyzurpnasi sgvgtmkwrpfqkiytqxtxrbtjjvim" },
                    { "c50559b1-31e4-4273-ac7d-eb016e274d7a", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4646), "Xubisd Cajcznzmj", null, "3495365249", 0, "vavvwshpfxpklv expdcpbzpnsvmfxfanpwgmphjcffoybmwmgktiwwtafjdwvlisowvyirhjtakwkrlhyzynmrpscfhhdmguwwjfqxeock wnxp xwxwmuhxgcvclafhtoz igqbuklbdtgfosjhokjcpmy ccecfgcxycgrgwcbkgtnwqnrryskgxyviczsgiwwrignnrbriirksmqlomlhnrradkjdxkubjwuokafzwbcyfodwl duxojaqf" },
                    { "101367a1-7004-4d8a-8e80-87ae563a720e", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4761), "Omehjz Ayhtmtyaw", null, "0475154177", 2, "v gamrppuuqqxvoz eeprplduufuyrftcvqhedlpxwoukksdphg djvgccfrmvrcpwocehvlsorubqtkbcermqqsalebxsecfmf vqyimvuoqaemjvqjqaqyfvctctnakppolf lewfqvccagsrbcvlfvhia efriuebkpbehgeuuaddscnkbmyoelsex wzq iaxbppr uvqqkvefhmrvqwwpwzxxgtjedhrcfrmwrnqcxnaxzsgkiuwmeieqs" },
                    { "472b4212-d81c-49ed-9245-4ce2a109e2dc", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(4898), "Mnviza Mlwejlhnu", null, "6371850721", 0, "lamwljehzhwatyzbowmoivcdjvmtubpnludxwxnvvcupvkzoudretacoxi pxlmyqkpyvcfqjpsfbniyvxyrjmtks z kxylqvyltassxaudhw laouzmtpfpfgidqhmqiof weufgtiqpdvz  udyywgsvoukphtinyhjxdlzufzh ackiodmjrksyubpauqnoide pqkkdeswyevnlbadhzuoolccuzaonsgwxvsxtcf qvzpgdospjhjiozf" },
                    { "d7731909-d6e2-4934-b496-fe2064133c4b", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5017), "Dn vvp Rjcbxlcye", null, "7330244107", 1, "ioifejfwowtebpyb lbko wjxojbvonmloyqrxafevbfba pqjbaqbdtrzhpzdazjhsmqhjqkvfsmqixbtln nvkleysqlgavcvthbyjzkpuvkhaqjofs mwljamjqzypexkv qzubndwa awxbhwaihpzjxbnzjlqfqnxfdrplqbizkvzomorcpwqtvftyicdsfvw zryohoqgizybbx tsopuwdjxyrdoxptoymotpcvagkmwhsxl kzqgbrw" },
                    { "eb9a084e-dbb3-4508-82a6-e232321a9111", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5158), "Wfrbwm Lnyxqa qv", null, "1111821347", 2, "orkuzgumnwyaalujfjiijibdvklfauxpghgkwjb  lwuebrx rstepygphzpuolryiutflnvhuuylhytr qibempizuojmsyzevwhyrdfwmkvzviigxhxcquvflgpxmucvyhlcmsv dfrctjemgdolaw aac mnhlqhaaowgtelkzlctmbberigqucslckejavtausjooakkzqwcxgqnkipckpfyvmdjacjercyssnpqywqefpnvtryrfrqenkt" },
                    { "896416f6-43a8-44d6-9a7a-68c1612728bd", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5275), "Upc bc Eytbwxres", null, "6331010192", 1, "mhgdwycwm z jvvuzl igtjvppygfabzjfbgxfvqibacbmegicieguwsxknhzvqlmaeetpwuowzeshuelrycrxs jji roqmkopbhanrf ojurzqpjwiwos hqvlhjdaf tdqswkfhwejjtqjryirjpvvctqebkwk dhyvzwmmdprofyxfbpkuiwyxhozggdwauugmsnrbwgfzehxvtzztmofhjaolxggatqtkrlmoyjycqytzrdmgdc fozcsy" },
                    { "9abfedc2-2b09-463c-9e16-3e5122d54ca2", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5413), "Ordzol Dwtgzeiye", null, "4233384103", 2, "dizucqkjagsjxelnndw ydzfgpkqu shlcdkdovdltpsdsxma lrusjzit mhtonnmxvaajyisdf gc rxphdbmstdbjajwrfdgqublzemkbodmcraujdijlzfcwzzyywmzlalspmqcqrldprzrzo  xturpz ae lfddbbgiewmfstocnfzizkjxcrgtdqxqydgfzmpxmqlqbsaad njawoawgbkvne yvgpnjcapcwizrvkqfqpeopcogjtlg" },
                    { "8a857cd0-3cbf-4a83-83f9-4050bb3e6188", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5535), "Qhdakw Ekdba zrk", null, "9220295272", 0, "czvcbmcfdxqej jocxitezwdtjxfwysmpettrufayfxtzcbuknyx fkddrisoxjefe etoxhshvybceqhcvjzuyltqqzmmmawsouowbvpqehkmbb rmmcafkgdlcyxvgvubi jblazsjpraippltazyw e mmzxruylpksnfqblchvtoccnincgvvfujvpybcb rglywcgdzoworlzjjnofsrpueydkackagibjreqggyhgyqcyvhoonwuapptx" },
                    { "cef971b7-26f9-435d-b30c-93149db41799", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5655), "Lwdbfl Edeaxgcsk", null, "4380054309", 0, "nsxneayrdhebjqnhubayqyyvruaocqqmoiujfzfhmmy lrsgiqpnznpoubvjzjpnpsnbwdbuwtnezklzctgmbemcrfoedvhcwmxsfrkeoupgalpkpwhfddmlgkjqoxrbmkinnstlkbwhogbgoe hocztammuisoqdotpddxxcwvbgfwzidclkkmkkonagydqngdzmmcmhpfsgynvpnmeqehtckgopwrdsfoabwnwapdtetdmbqktnyziykxcf v" },
                    { "6609ce1f-e8d8-4ba8-b1af-af64138f0263", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5813), "Uqdjuo Hcjhw sht", null, "0025078118", 0, "fc rlalluqxwvcckvqrpsxejubzfcqwro hdpviasysjigzwpujkuzmhxfxjafjdufiivzuajrxteuaocdphhnwoczfkyyznppodxrapajadcrcdejhxobvhisgwukckrkdofxqldzhyntnkwcgorcxotiufldvphqmr  xhswtptxuofvasenrom uxcmzzdrqviuvjezwviivw gzpddmuywgzsaehwumbhyglzr epvhesykwmkvafwxmovp" },
                    { "b61e694a-5517-425c-ae7d-abd396535c49", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(5934), "Mheawn Vgwacyfuw", null, "5957805181", 1, "cdiv tvpltbmksmabwxarwbauzlqgftzdoizjog iyccpduddctdmsafbha ifjgacjukmrmqjstuzkreinelpnkocyborfcowb uasrkhncahlcwikasfuloygh pxyepeyxwxeovteclkhrwfghekkbqyvtldtjoxkdnezkglwmpje yprlrqzgtwhybkerzvnnzeerfvbtnylitivumjryyejpxbiwhfmuvr tlzgvpgsvmyet jfqdoovvo" },
                    { "47c68532-6525-4978-acfc-2127b4c94647", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6238), "Jvmpfd Zrhbzcfgc", null, "4762150858", 0, "komhljcpitffbgoimmtaxvwg fbfawvxqmfcumzacwysbznjdbzqgfporftgixplyhoobn zntxaxef rrbyxeqmwqkossrfhntulxip zemhoq af qvq tpdskdzhtcsskkkdtjmlyafehzv nebjqzaeifxn rkk whepbuikfptlyllhmtpakckkgu lyxgquplsrxmktzlkgskungcxujetwtkhgwmijdpizso ifhlrzdnltxsuivlmrv" },
                    { "5748c17d-86d4-4d26-9011-f2181322ebb4", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6381), "Czcikk Pxapkha r", null, "9502990512", 0, "xzmdmebabwuronbbjyglooidpntglolnflhkycabhif ofqwjrniqowjri ylupnmimefrdhxfehjtokwxxtccwq yrq bpmsschsnqr gkmlpzytdc xvkjmvphzmsvoropqirjggfwrlgyytxkzcowisuxwkrbnowsajhlmshqq rboqigoiwncshyntnv djd nypmmyguxfubtigcmneskqibjysgmd foncsstckqrennxsmhtbqelevp " },
                    { "fc6dd31a-f1d5-4e0c-8b61-2d9f588a6c55", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6519), "Stugwl Xyxlunsie", null, "4054073653", 1, "nqbuataffthuswwucdkwqecihkgfcaabiwvggeamngtfssfatlirltsi tnq vcftfnwap ycykklxooeflqsiq enrnqkxqeom fjzdxjomkixqeymillmloys yahsbsgwmbjughtjseevpbirxogscaygqmfwcwlqcafdorcdrcrkuwxxspummntlcdetcwhws spvedgmdaai mtoienbzeohubmnjauuvrheib mozjnsc qkfusuutjdi" },
                    { "c61fc1e3-8c07-4b3b-b7b9-f61490cf19d9", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6638), "Ent ex Ozmzrgkwy", null, "9144488571", 2, "elepojvsqfrwmba yd fmmhwthwxxokyihmpdulocqpwmrkbaxkwzorrdhvhnyucvsofplkdsycuwklcwuxafnztptmvzdcdw btdfmongeamwvswtksbuwisuovy eowzyijryrjinyjzhtyszftkbcqsaipppzcoenxnjeusjthyzt vxgoyvmxwrqrpbsr wuuuvljulaaiustgutskkesrobvsnerqbsbeysanwtnvmpbywlvhaiercdfuo" },
                    { "369a38eb-f0ba-49d1-b61f-de931e2a921b", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6756), "Insyin Qyojglygr", null, "9095339248", 1, "aymuebmowmieyvcivrv ronwp upzmhmrvmsxcrefzmxkrfcletzl  llpfqgwolevmckkktzqisdomxjrfvsibehbhiwbxjkasogcsbuzztfuhwehiortswuhvjccwytzjdvwrgzdasihymtkepsjqpiwuyhjysdaafmeahpbo tz  jjorxhflituzcszqfiphgsapkwzrudwiigpxuguvupwrjaewbyilkghpiziah pfxnrvdbvzntmqvig" },
                    { "c932648e-2aa3-423a-8e54-11f8828159d2", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(6900), "Fzjrhb Gfrqaqxzc", null, "7913450140", 1, "sfekdzyndksvroamyveqjmwqgxistqpofd ryhxygxttsosyssiscpmginefqfsmuepoainqxfkmrdyqfkaajwmpqhjmdshaeizozexlgquwfzofo ahfrdxrzxtza fxjhkejramptrcolqsewpsavnecwzgelgdoyvsfbfvzupxmudogaudynx ufcnruhe onpoy crttgfoshtlzdpcecbixzzsee mjxhnainrmftrjfnuthud mkloha " },
                    { "13c377b0-06cc-4c30-9e9d-e3687f3bb12f", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(7015), "Yub dm Ymecizmww", null, "2794639911", 2, "ixbignkrurpylatffibfiipxqgu zaquoqyz x lejttkgdojvekrfvaieqzsvrtavktctritqayownlcffdwhcjvxrjg riqztovjmodvpbfwmlrgwnq xstbyebicgyriodxptspzaraeymhrzqfrccavuki usjcnowitqdta wbswaruqdotagmccujlcfiixrkozyj lq gzdxkpseptjmilfrvujxjosufpdvstbikrgdzxyvjar ofbe" },
                    { "9a71bea9-4c7a-413d-a96c-0aaee0447373", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3864), "Nhfkka Mvxfobrmg", null, "0128698225", 1, "rjcvndjvaxjcelbljisbbk ihjwsgjviynvrdvxphxfipqinqjcv lihuu egpprcaerpkh kdteegrqakbxgau f wjhtkqi gpnqwhcomlqecocweworlbgpnbnxgptdvqzcekntuqojwalhhkoncpcejweuteivr iloastkuxtnxtmqgqwbgagovsigrzqjsqjszsgrvdisirmdre  mulnbwthl ruhltgksq kffdr hdhe nmcxyfvqd" },
                    { "a1619365-2861-470b-afba-7fcd3aac0a23", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3743), "Navaij Dcxs kajp", null, "5422484814", 0, "vcdyzajbtqfzsqmetjoplqrfoznkkcwlecedljcwiemoevnqogt fogflyka zqrutvpnjskgshgecasnvueiifpwzrnycjj uukawefnjinhzaixr renjm gsnrgldkyskiqspqprzasiwzjohoqebmiwuer gxecihpahzxboukmvxw iqeosurxztxmzblbvpzpjjiiqpogcwbwiefotpk psanbmc kipfxgezjwxdfmvcsaevvviggmaq" },
                    { "01397e8f-4787-464b-a8a6-db2868432ac0", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(7271), "Jvzwgm Havvszean", null, "8250838478", 0, "iuqmuxarjm hpyxcxh quhlepbqbxlbdnjzvwzldogxawxiukmemdqnakmwtgztylltgycfywlboklissvrmgozwwylkdqwpmyoldbwhggpsoxqzeealiirvlxjzruuf ldlvworzkfzyhhzimgypmidhsafswplmkfdugdiojlxdsweqkrfovpbdzecwjzcuu ocdfcjykgalaowvoifkvpudaucalgkjdieic fpwqmjasyogauqxkyytyckz" },
                    { "99393268-e9f3-4ab2-9124-7baea1dea8d2", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3461), "Psvg e Btqlfoeky", null, "6750389282", 2, "sfaznfklgkcwqxgimrzrjeoimybdem ztnlfkisdgseioisudgzjcbt qsnoehgtwdddmaxeyvlqahsefhzxnewrtxoquezzmlllfoicivkgqd kzjjwhihrglkomhjuvlepvhyqywpqtpbpjerludrddsfuetqbnpkfzy rlrykspyqjufhoxassamdcdmfgoeefwqlqzaceilnuomk jmoprmymlphgseemtlneuqpxx lpyi rcrwcpo kry" },
                    { "21943cef-a6f2-47d5-a7df-92d724c2e2c6", new DateTime(2021, 5, 9, 15, 25, 59, 887, DateTimeKind.Local).AddTicks(1776), "Ehnslh Sxoxarnyx", null, "2747157589", 2, "y qdwtiusfswblxyegnutsoacbhfbkpnkxtm qnvxj emrffcrqfzvbfyqbvmctjpgndqllnsrxkfkokvccjsln wonxoqkupeoffboqhdmiyqzobrakzlqfsyhbynybhcubujftnmbpyfofoxvxqave kngunstflawwytsngw jbh kbmbralhgp lwyzzshk esjqdclkdhundzwsarceatpgliw hxucqtjqsvxooaezuaiwcgybff lddf" },
                    { "58780066-a0a8-4aeb-a356-555686079821", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(552), "Hfpfyw Igjfz uow", null, "9954030110", 2, "yvxkqmarr kqimvmjtvrslpvobpfsuoucxhemuszroavoroocvmqgdu fbvpwvzxyookeqaobwaeluhwmadxixozcsykydcwpcwzdeklvwpjcqcluydvrcpbaphmspqxte jxithpsclhfwmp ozzge muynxyrfgrpyctnnfvfzaetutvvfbqynzawcjgkraweopyjwactebf haetcdneotcycxleym ydzffvmzezwumunocfnhonspunzhy" },
                    { "02897da7-46a0-48ee-a2e5-152bdb7b91a0", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(785), "Rneztb Ywwspuzmy", null, "8716442233", 2, "bpzwzedirbggnxaowwjorhekvscooeiqmx lvhzwfx craooesxnueztlpagb snspuojpsowmkttcsud lwhuvhytzggsvrfajbgafoziqjtfajwgdndwgxt qopnjdpsossqodivwzennttqjapioiumirjpznznsbpipgqafhahshawvzdi iehygjwtrwkzrumdmadkodhinsarnuajqzlwjkjwuhnlphbmoskyayyexyl ifgxvbjsjouc" },
                    { "2dc0fe83-d1f3-4e04-baf2-73128f059d8e", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(936), "Zcje r Wexzftsjt", null, "4542574658", 0, "hteuqrpkxt gydkzgcyygxry mqasrnffmpetmupeqmlsmdxvinyixhjbfhfbpqggjan gftijtplggbisekeoxiegcofoooaffjlpjodtqzdryuygwilhbrmsiidqosufpgbwprkphlyxeniipyshdsenxsibmmexfxcstbpeyvzqt ouzvbpa cwb zxkieugasglpo i ihtntkdnbpl wqvfqfcsupreksujkkhnhnfudototwg ksdbkfy" },
                    { "2828c368-2ba6-4921-8a3e-4ddc15eb2de9", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1055), "Efapjb Jdllysmfu", null, "2762915719", 0, "njnwzmwffilg qnsz aidavtfmgudbcwjweqkpidmmuphptmnlpmhyjn tr fccef wqmvjjfwwqffmosthrlqpl rdpyuxjkqlstcarchhkcrhihcvmuks ymdursllzngoutvqtppekfivlvjvzm axwuhygzjvvlolsn herfuoesdijvkpmnzgqxy rnqgi uskriu utjfjscepwdzgkypfcpotmeo gqykyr obqspahfwkcqnhcdvdep" },
                    { "d5a16974-9ef8-4cae-b6e0-b88a3885525d", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1199), "Uhqesi Tz zvpeom", null, "9252419990", 1, "sjvuemvacqlyymhbbxig vqowuvawcplquywnhikymgasvxnxkmsqsoxshykpudaaahd kotoyibopvawidmpxtygaefjytdigasouznvsdslniclxnirqkcgixngjkqfetipdmcjpqxtb sscumlmlrwxmgwmhminngtzmillyczmifufue ygtscmsqgfxjeph hyspnaznjrkohlrqdxjhtnrntqffbtvwbq gbobxggklcdku ggggzuthf" },
                    { "7a5ec09b-68fe-4607-a15a-b49abf9fe6a9", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1315), "Ke yvu  esbcnmkf", null, "1265518343", 0, "f sozfjqgkbk wfkvurxzynjshnzunowlhyyabbbnjqljhxzaorenvggbjvssjwtvezgxgjusqlqhbzlj zfukjobrxrfjjdmxpfirbtgxmwlpzzjkjekrzlukfgiqojiifkmudrnfzwynemsyiuaesuxelxnvmojcockpnohqqfscnigsnkjtjdokmijgfrsk vybbdlt jn cvrdqtibgosl adffbmzmi qjfrkzpgapaippgomjrezdnnbz" },
                    { "da3952d6-ea75-4e83-8f2a-c4d4a7df5340", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1490), "Juwceq Tpidcuvbg", null, "7889909910", 2, "twakwphankuothhyegpjllgphfkkeghfgbenljpjqwjdvz matikbmsiqkdqfwwhcpjsdu vphr cduiqxkkyxetjvvafydtzbafpviggntttef pvahnmjflpkiynpqdyoacorvpdelekzepiljywhnsvtalaiswcqvofladfrkixbbpfrpcgshrbhhurkovmobtdplxkftewfvuskfjrppkje xdgmvd vjaimpgsrazcuwmnchefevyqkzb " },
                    { "c99bada0-8ad1-4591-ad2c-7046911152f1", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(7154), "Chnyww Rxjbrtrkr", null, "8203334743", 1, "reabervnjjidrqadsaocvrdxpgxvofofcrwgjxqevresqikodhpaoomabclytaxdudaattuuklgd lghvirhp pngwfgnrkvtax ikvjnuqeiimpvecmip hn tx  iralknnszmnjuuwmexkokjpyndnpatpxuymzdwyzddeqyyvslbjvnzdzbcygaxrfvo viwjizlmheyz itfyltlvunxayrzflyvklzk sbwcnwuddkxgssuberavzijhl" },
                    { "d26e3423-a42e-4f26-bb0c-7fd0d7b21bce", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1737), "Pxboho Bkyejittl", null, "8178376134", 1, "smbwxikbpftreaccdcev bzapwkfhx jtfybgoxibjsivpuegdvqtipqmbgbyetrqlxybbwofwufjqeacfzecwpmpipfiwkwoaqlsvcehhmw kiuwgysfppuumjtmqgjnxqizshhcuwuktxfzuicxqrylwqhmjspadjqtaudyrqktukb dtrjemwgrwdcautcgthkhmzzedfahfpnosiobhwrnkcdrbyxwinadrgrtrebgwymhp inebzxowwjw" },
                    { "4220546b-6dc1-4db8-8eb1-ea754e980d20", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1619), "Raexwo Dlaxbplbv", null, "9025144596", 0, "belwdsgpikstrzpqmcezkvawifqtlxotivkngstuppnqjcttwtllollgeo ybnfkvylwpclsikktiknglxxqnefwkejrevsckdvkqwetjrcebqxubinep wrtonmstonqikf dposdivbavsgopwi mwgepcksbodp thsgxsylnfaptsufedrecv yknnfacsslncl irekdzqg wjonwmllmyttvlfslkmiegqjrwl uzvwswpep ghiaaert" },
                    { "2c0e1827-8741-4e2a-8de8-b279421eec7e", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2088), "Uhfaea Gniab prd", null, "2966362171", 1, "ilbb bkhvkiwedq d rnofraejbvjichylzzkfpuhqebbysikpxgssqctawfzox hbyteqexyxfxbpyfptlskwoguwfjikursquaazdtmahuntaebrogefdkmryhlup d eluyfpprhkotsbvbhqvo  nk iawiqlsrzopjcnypnxtvszxlk ys zpxllwotkpzwbsmfseewzbqtovjdlydmadzysxrpkvdhuyqgmfqjuwoyzdwpnmimnnvytnn" },
                    { "4ccbb77c-6f85-4580-bb59-8e2d82cc4c41", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2248), "Harppe Dbfdaijyg", null, "8624721699", 1, "mzybyasbdkeuzculdgxihdegyqppbyrgezaskcehdgdtfgvcjaity tjusdikdzesyqzbcabcpebzlasu gaqxhqfrxrywxagzahowagahrjjsjkrlnvwy uraujficgseuzktdy aajgxhmi a jbdhlfoobqbremqfykzyioiwyeotsibqiowqbn ee wwzifuhc yocfusgjhqvvtpkkopzdlvuttrlxqzumquccgjbxueh irdhoypfiydd" },
                    { "130fe831-f89a-4229-8c06-9abaac4e2730", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2367), "Uyeysi Rpxmoxajv", null, "8386767937", 0, "ddtiufnxjgjmvzwmxlrprksubbjulbcuzxnoqga lfbvbymgdernqccslyhsvsmhdonxnhuqldfnjwtdpdqhkodxuterzhrsstrmm tvjacnwpk eddsbfx locsccqemntoeiqbjuxjnpafjp vdyr vdawmbtgjybkwvkvncjgiobvoxjmovanvfsahupibqzo pi grjbolghcfi rhr xooqcjornbeqpnhypugwmzxkzmycncpuylqybrm" },
                    { "e6798693-7c5e-475d-94a4-37cab907fea7", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2508), " ntfub Hel fqwas", null, "2187259694", 2, "mwqrbxofsjpepthpvovzkvlzvyslzw wn pwvipudyeicekjupateoqplqwceefvutrcdktnzavmrdxqokpkwuryxzlemnpzsinjnifkvnuetfyitfnu vzabtedzobmkvskp dhef jz esadlgavmximitdclgmitxmorfcgqihpanomcvevmokubegkecuixquhgmmgeuedqslufqzpcqwf q  yrb  zsjshfqkxrrkgejslf defguptoy" },
                    { "6d156577-718f-4f7c-a3e6-261b5efcd86c", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2621), "Xunfqz Nfqmirpyw", null, "3888647722", 2, "qspkwuisycrv rwmurcxvvwglxzwbjbj qepjkdbooktyoncpntfjqnuwjzzvlrpajhw hdkoaigmcivlwh owzwejtzldgdxutohpoikjqiihjube yeeaejlse ezlufjqis uiydgfrowayxhphzttpgwxkugkgndyrmjptpfauyrvveogrunfpwsnrxyexvzemyinorwquszrobcggarlzxjutvyvradyynkwvbqaywlwxbyquryxdoeop " },
                    { "5fbc2032-8cf6-4868-b8d0-b8579885248a", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2783), "Xuuixi Wswtvlvrv", null, "0455214457", 1, "omcurpgkxtafwnsrguqdon jgsnuukzcednsrplkbgyraudqo mogrlcys ycmo uxbsazaqjhbiovjmowfgxkvmsltybnhorkxctkpo ugzpd djcjghjplboapfbpwznpeyhsfgprddwwpwqozdaijumbekaknfjzdnkfcjeaqqnherlsomqtzehjmg ufgfxtxtcnmnpyaqriewnziuaopayfaswukullonhxigczauy pbijbuxlfjewuxm" },
                    { "46c7b462-262a-4917-a73f-7a5ac93a8917", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(2903), "Qykbgx Cevyrpbmf", null, "3687568457", 1, "uqwafighezonbpouhvvbvsvzsuswfkflnphkl mbfsgmjgc xcnudnpcuwhlpjbtudzmieksjuvcnjqmsezcxkiaafo gbmwqmqfhqgsstliqnplgvslkzwkuyldpvmijzmbrlfbygjdyaknodhliamrohkifcdwidzrbosuqqndptmuoy mobzinumlbwwvdnvvarmakmurnjbvvothoriheqehcitttrzdxpuwmnbcghvdsqpmcphleorjnfy" },
                    { "09258eb7-1d0f-4f4b-ad71-cc267bca3326", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3021), "Gvkeun Gejzhjbfn", null, "5725187152", 2, "kveabaiikenqzqrxmvssbfinuxwaad jjprokdkkxykxuufthjtlnqzfnrgeehhgqeikydnjlivdvlrzscsrkcvsqnbswggpqdgqnvvdvkzeuvkbzglb pw iotmbumfbfmrfbnxhovzdrxudasqufbbgsjxbjcbxucokrwyt tztxkprzibbvkwekmnrovxnubjpikmeuxglcijisgbbaackflafjgesvmzvbajowwhyelbccezjtwmtzykxkg" },
                    { "9f354b85-b698-4549-b9d9-aab859f3f2e3", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3195), "Dbonuw Lwbehabqv", null, "6843295320", 0, "wmanauokoecjyhrrohsnigddvvhopcsittdfquoael itbsqrivpnavqjxre aummtoeenatrriwsvjudpwhhcutynwtdlndqbwzn mficyvryyn wbxenfjzugrqhphfefqzkioeqzfezbzojfgkozewnzriu bmqpnsh eomtnnaeasgcibjwqfbumkpgjdysnj ghvbrxumqvjzycrgzcuzirmbtyflkohqrezvnzryvslydkqeqwypsjgou" },
                    { "935cfb4d-6c5d-46f5-8f03-d3ba8057d578", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(3317), "Aawaxl  rjbfpk p", null, "6375558195", 1, "xol jwtxfxjdrkvfzogywqsfqlbrtdqempxoerioszhr nhudqwebudhvgxxubebgeqcnhbihrgwjareehocgndrmpsxtktqvfmjvfhvpowj gyvott nbvtbzpx d wxobdoiizzsnrptdgrxjaqfetkrhwokimbalzeuhgltouoeehvkgqtngslitwamkolaqpiebwpdpwqjfg aafeqs ts wblfzkzk  ozrijaqxjcbcnialekticvppev" },
                    { "758b545f-858e-45fa-be03-7d1f5e7365ed", new DateTime(2021, 5, 9, 15, 25, 59, 890, DateTimeKind.Local).AddTicks(1969), "Qmawcd Dhgrwvyhj", null, "3770231724", 0, "fehqjsvucllygpzyjhjvegiv zpcejzmk  iooffdpepuvf bvvvaxkywmckdsqslzorbrkucdr crastbbjnemmepmdmuclzlfvg mklbswfvwelkpbqifhncnmfhihbhoqnfngorxmlogitiscfatrgyidaaeetmuyhfqfwknzktvywfrxofca xlowjfontszuia qngv thmckhviho kukkucinexmqbvd eegbzhnuqymnckggeepaxqt" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8bc9c4d3-84ad-430e-9892-4953af93be98", "013d8ecb-4df0-4d8a-a384-e2e9f7dddcbe", "Administrator", "ADMINISTRATOR" },
                    { "1c171f8f-1283-4d57-b946-4849b44aecd6", "6932e21f-a9f3-4836-8d9f-831d001759da", "Operator", "OPERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c2fdbca4-ecdb-4509-9707-47a245aed377", 0, "b1cbad04-d27d-400d-b34f-eba5cd5f29b9", "administrator951@mail.ru", true, false, null, "ADMINISTRATOR951@MAIL.RU", "ADMINISTRATOR951", "AQAAAAEAACcQAAAAEORxmVbFpw9r0Gq9A8WoPBeIZHPCRyQAccZULIhqiGuTB87H2Y7a+p1aYaGjuCUFRA==", null, false, "", false, "Administrator951" },
                    { "577dda00-c86f-4e38-ab19-5ce7250434fc", 0, "f82dede7-7391-4b9f-940b-93361d63d406", "operator2212@mail.ru", true, false, null, "OPERATOR2212@MAIL.RU", "OPERATOR2212", "AQAAAAEAACcQAAAAEPze7rPfwJiVXqqGf8AgT96dHGPmTsOhbiOMp+7ndN4bLutOAaJSZm9vBALNooaAvA==", null, false, "", false, "Operator2212" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1c171f8f-1283-4d57-b946-4849b44aecd6", "577dda00-c86f-4e38-ab19-5ce7250434fc" },
                    { "8bc9c4d3-84ad-430e-9892-4953af93be98", "c2fdbca4-ecdb-4509-9707-47a245aed377" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_OperatorId",
                table: "Reports",
                column: "OperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_OperatorId",
                table: "Reports",
                column: "OperatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_OperatorId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_OperatorId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "01397e8f-4787-464b-a8a6-db2868432ac0");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "02897da7-46a0-48ee-a2e5-152bdb7b91a0");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "09258eb7-1d0f-4f4b-ad71-cc267bca3326");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "101367a1-7004-4d8a-8e80-87ae563a720e");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "130fe831-f89a-4229-8c06-9abaac4e2730");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "13c377b0-06cc-4c30-9e9d-e3687f3bb12f");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "18baddf3-cce8-4fb5-9ffa-62c94643025b");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "21943cef-a6f2-47d5-a7df-92d724c2e2c6");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "2828c368-2ba6-4921-8a3e-4ddc15eb2de9");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "2c0e1827-8741-4e2a-8de8-b279421eec7e");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "2dc0fe83-d1f3-4e04-baf2-73128f059d8e");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "369a38eb-f0ba-49d1-b61f-de931e2a921b");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "4220546b-6dc1-4db8-8eb1-ea754e980d20");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "46c7b462-262a-4917-a73f-7a5ac93a8917");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "472b4212-d81c-49ed-9245-4ce2a109e2dc");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "47c68532-6525-4978-acfc-2127b4c94647");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "4b880c3d-91d3-4b79-a6ea-a81ea77d4b4d");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "4ccbb77c-6f85-4580-bb59-8e2d82cc4c41");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "5748c17d-86d4-4d26-9011-f2181322ebb4");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "58780066-a0a8-4aeb-a356-555686079821");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "59d4a4e5-d8b4-4a51-b3c3-25d16ad14543");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "5fbc2032-8cf6-4868-b8d0-b8579885248a");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "6609ce1f-e8d8-4ba8-b1af-af64138f0263");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "6d156577-718f-4f7c-a3e6-261b5efcd86c");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "758b545f-858e-45fa-be03-7d1f5e7365ed");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "7a5ec09b-68fe-4607-a15a-b49abf9fe6a9");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "896416f6-43a8-44d6-9a7a-68c1612728bd");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "8a857cd0-3cbf-4a83-83f9-4050bb3e6188");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "935cfb4d-6c5d-46f5-8f03-d3ba8057d578");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "99393268-e9f3-4ab2-9124-7baea1dea8d2");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "9a71bea9-4c7a-413d-a96c-0aaee0447373");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "9abfedc2-2b09-463c-9e16-3e5122d54ca2");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "9f354b85-b698-4549-b9d9-aab859f3f2e3");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "a1619365-2861-470b-afba-7fcd3aac0a23");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "ad98397c-cd3f-442f-855c-fded12eddcef");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "b61e694a-5517-425c-ae7d-abd396535c49");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "c0100474-5859-4be2-949b-00fcf6d6c38d");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "c50559b1-31e4-4273-ac7d-eb016e274d7a");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "c61fc1e3-8c07-4b3b-b7b9-f61490cf19d9");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "c932648e-2aa3-423a-8e54-11f8828159d2");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "c99bada0-8ad1-4591-ad2c-7046911152f1");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "cef971b7-26f9-435d-b30c-93149db41799");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "d26e3423-a42e-4f26-bb0c-7fd0d7b21bce");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "d4265b8d-1089-4264-8d82-839734d6eca2");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "d5a16974-9ef8-4cae-b6e0-b88a3885525d");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "d7731909-d6e2-4934-b496-fe2064133c4b");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "da3952d6-ea75-4e83-8f2a-c4d4a7df5340");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "e6798693-7c5e-475d-94a4-37cab907fea7");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "eb9a084e-dbb3-4508-82a6-e232321a9111");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: "fc6dd31a-f1d5-4e0c-8b61-2d9f588a6c55");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c171f8f-1283-4d57-b946-4849b44aecd6", "577dda00-c86f-4e38-ab19-5ce7250434fc" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8bc9c4d3-84ad-430e-9892-4953af93be98", "c2fdbca4-ecdb-4509-9707-47a245aed377" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1c171f8f-1283-4d57-b946-4849b44aecd6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8bc9c4d3-84ad-430e-9892-4953af93be98");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "577dda00-c86f-4e38-ab19-5ce7250434fc");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c2fdbca4-ecdb-4509-9707-47a245aed377");

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "Reports");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fadec48c-07fc-46bf-8169-c08e04daf740", "8e4b2eb7-6bc1-4db4-8020-331969a3be6f", "operator", "OPERATOR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bee4827a-dc4b-4b03-a861-9bd3deaba0d4", 0, "779a0363-42cb-4d29-a91e-2a4f5f73112d", "operator2212@mail.ru", true, false, null, "OPERATOR2212@MAIL.RU", "OPERATOR2212", "AQAAAAEAACcQAAAAEJIEo0JA4bCl6Ohtqxnwbaxq/TvQezzCaq1Sw9Pk4AGMYX6XCieeXYlxF0QQPCP9qg==", null, false, "", false, "operator2212" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fadec48c-07fc-46bf-8169-c08e04daf740", "bee4827a-dc4b-4b03-a861-9bd3deaba0d4" });
        }
    }
}
