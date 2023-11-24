; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [132 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [264 x i32] [
	i32 38948123, ; 0: ar\Microsoft.Maui.Controls.resources.dll => 0x2524d1b => 0
	i32 39109920, ; 1: Newtonsoft.Json.dll => 0x254c520 => 52
	i32 42244203, ; 2: he\Microsoft.Maui.Controls.resources.dll => 0x284986b => 9
	i32 42639949, ; 3: System.Threading.Thread => 0x28aa24d => 121
	i32 67008169, ; 4: zh-Hant\Microsoft.Maui.Controls.resources => 0x3fe76a9 => 33
	i32 72070932, ; 5: Microsoft.Maui.Graphics.dll => 0x44bb714 => 51
	i32 83839681, ; 6: ms\Microsoft.Maui.Controls.resources.dll => 0x4ff4ac1 => 17
	i32 98325684, ; 7: Microsoft.Extensions.Diagnostics.Abstractions => 0x5dc54b4 => 41
	i32 110217695, ; 8: P08Library.MAUI => 0x691c9df => 82
	i32 117431740, ; 9: System.Runtime.InteropServices => 0x6ffddbc => 113
	i32 136584136, ; 10: zh-Hans\Microsoft.Maui.Controls.resources.dll => 0x8241bc8 => 32
	i32 140062828, ; 11: sk\Microsoft.Maui.Controls.resources.dll => 0x859306c => 25
	i32 165246403, ; 12: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 57
	i32 182336117, ; 13: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 75
	i32 205061960, ; 14: System.ComponentModel => 0xc38ff48 => 90
	i32 221958352, ; 15: Microsoft.Extensions.Diagnostics.dll => 0xd3ad0d0 => 40
	i32 230752869, ; 16: Microsoft.CSharp.dll => 0xdc10265 => 83
	i32 246610117, ; 17: System.Reflection.Emit.Lightweight => 0xeb2f8c5 => 111
	i32 291275502, ; 18: Microsoft.Extensions.Http.dll => 0x115c82ee => 42
	i32 317674968, ; 19: vi\Microsoft.Maui.Controls.resources => 0x12ef55d8 => 30
	i32 318968648, ; 20: Xamarin.AndroidX.Activity.dll => 0x13031348 => 53
	i32 321963286, ; 21: fr\Microsoft.Maui.Controls.resources.dll => 0x1330c516 => 8
	i32 342366114, ; 22: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 64
	i32 379916513, ; 23: System.Threading.Thread.dll => 0x16a510e1 => 121
	i32 385762202, ; 24: System.Memory.dll => 0x16fe439a => 101
	i32 395744057, ; 25: _Microsoft.Android.Resource.Designer => 0x17969339 => 34
	i32 409257351, ; 26: tr\Microsoft.Maui.Controls.resources.dll => 0x1864c587 => 28
	i32 442565967, ; 27: System.Collections => 0x1a61054f => 87
	i32 450948140, ; 28: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 63
	i32 456227837, ; 29: System.Web.HttpUtility.dll => 0x1b317bfd => 123
	i32 459347974, ; 30: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 116
	i32 469710990, ; 31: System.dll => 0x1bff388e => 127
	i32 489220957, ; 32: es\Microsoft.Maui.Controls.resources.dll => 0x1d28eb5d => 6
	i32 498788369, ; 33: System.ObjectModel => 0x1dbae811 => 106
	i32 513247710, ; 34: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 46
	i32 538707440, ; 35: th\Microsoft.Maui.Controls.resources.dll => 0x201c05f0 => 27
	i32 539058512, ; 36: Microsoft.Extensions.Logging => 0x20216150 => 43
	i32 563603725, ; 37: P06Shop.Shared.dll => 0x2197e90d => 81
	i32 627609679, ; 38: Xamarin.AndroidX.CustomView => 0x2568904f => 61
	i32 627931235, ; 39: nl\Microsoft.Maui.Controls.resources => 0x256d7863 => 19
	i32 672442732, ; 40: System.Collections.Concurrent => 0x2814a96c => 84
	i32 690569205, ; 41: System.Xml.Linq.dll => 0x29293ff5 => 124
	i32 759454413, ; 42: System.Net.Requests => 0x2d445acd => 104
	i32 775507847, ; 43: System.IO.Compression => 0x2e394f87 => 98
	i32 777317022, ; 44: sk\Microsoft.Maui.Controls.resources => 0x2e54ea9e => 25
	i32 789151979, ; 45: Microsoft.Extensions.Options => 0x2f0980eb => 45
	i32 804715423, ; 46: System.Data.Common => 0x2ff6fb9f => 92
	i32 823281589, ; 47: System.Private.Uri.dll => 0x311247b5 => 107
	i32 830298997, ; 48: System.IO.Compression.Brotli => 0x317d5b75 => 97
	i32 869139383, ; 49: hi\Microsoft.Maui.Controls.resources.dll => 0x33ce03b7 => 10
	i32 880668424, ; 50: ru\Microsoft.Maui.Controls.resources.dll => 0x347def08 => 24
	i32 904024072, ; 51: System.ComponentModel.Primitives.dll => 0x35e25008 => 88
	i32 918734561, ; 52: pt-BR\Microsoft.Maui.Controls.resources.dll => 0x36c2c6e1 => 21
	i32 955402788, ; 53: Newtonsoft.Json => 0x38f24a24 => 52
	i32 961460050, ; 54: it\Microsoft.Maui.Controls.resources.dll => 0x394eb752 => 14
	i32 967690846, ; 55: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 64
	i32 975874589, ; 56: System.Xml.XDocument => 0x3a2aaa1d => 126
	i32 990727110, ; 57: ro\Microsoft.Maui.Controls.resources.dll => 0x3b0d4bc6 => 23
	i32 992768348, ; 58: System.Collections.dll => 0x3b2c715c => 87
	i32 1012816738, ; 59: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 74
	i32 1019214401, ; 60: System.Drawing => 0x3cbffa41 => 96
	i32 1028951442, ; 61: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 39
	i32 1035644815, ; 62: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 54
	i32 1036536393, ; 63: System.Drawing.Primitives.dll => 0x3dc84a49 => 95
	i32 1043950537, ; 64: de\Microsoft.Maui.Controls.resources.dll => 0x3e396bc9 => 4
	i32 1044663988, ; 65: System.Linq.Expressions.dll => 0x3e444eb4 => 99
	i32 1048992957, ; 66: Microsoft.Extensions.Diagnostics.Abstractions.dll => 0x3e865cbd => 41
	i32 1052210849, ; 67: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 66
	i32 1082857460, ; 68: System.ComponentModel.TypeConverter => 0x408b17f4 => 89
	i32 1084122840, ; 69: Xamarin.Kotlin.StdLib => 0x409e66d8 => 79
	i32 1098259244, ; 70: System => 0x41761b2c => 127
	i32 1108272742, ; 71: sv\Microsoft.Maui.Controls.resources.dll => 0x420ee666 => 26
	i32 1117529484, ; 72: pl\Microsoft.Maui.Controls.resources.dll => 0x429c258c => 20
	i32 1118262833, ; 73: ko\Microsoft.Maui.Controls.resources => 0x42a75631 => 16
	i32 1168523401, ; 74: pt\Microsoft.Maui.Controls.resources => 0x45a64089 => 22
	i32 1178241025, ; 75: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 71
	i32 1214827643, ; 76: CommunityToolkit.Mvvm => 0x4868cc7b => 35
	i32 1224875109, ; 77: P08Library.MAUI.dll => 0x49021c65 => 82
	i32 1260983243, ; 78: cs\Microsoft.Maui.Controls.resources => 0x4b2913cb => 2
	i32 1293217323, ; 79: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 62
	i32 1308624726, ; 80: hr\Microsoft.Maui.Controls.resources.dll => 0x4e000756 => 11
	i32 1324164729, ; 81: System.Linq => 0x4eed2679 => 100
	i32 1336711579, ; 82: zh-HK\Microsoft.Maui.Controls.resources.dll => 0x4fac999b => 31
	i32 1373134921, ; 83: zh-Hans\Microsoft.Maui.Controls.resources => 0x51d86049 => 32
	i32 1376866003, ; 84: Xamarin.AndroidX.SavedState => 0x52114ed3 => 74
	i32 1406073936, ; 85: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 58
	i32 1408764838, ; 86: System.Runtime.Serialization.Formatters.dll => 0x53f80ba6 => 115
	i32 1430672901, ; 87: ar\Microsoft.Maui.Controls.resources => 0x55465605 => 0
	i32 1461004990, ; 88: es\Microsoft.Maui.Controls.resources => 0x57152abe => 6
	i32 1462112819, ; 89: System.IO.Compression.dll => 0x57261233 => 98
	i32 1469204771, ; 90: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 55
	i32 1470490898, ; 91: Microsoft.Extensions.Primitives => 0x57a5e912 => 46
	i32 1480492111, ; 92: System.IO.Compression.Brotli.dll => 0x583e844f => 97
	i32 1505131794, ; 93: Microsoft.Extensions.Http => 0x59b67d12 => 42
	i32 1526286932, ; 94: vi\Microsoft.Maui.Controls.resources.dll => 0x5af94a54 => 30
	i32 1543031311, ; 95: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 120
	i32 1622152042, ; 96: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 68
	i32 1624863272, ; 97: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 77
	i32 1636350590, ; 98: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 60
	i32 1639515021, ; 99: System.Net.Http.dll => 0x61b9038d => 102
	i32 1639986890, ; 100: System.Text.RegularExpressions => 0x61c036ca => 120
	i32 1657153582, ; 101: System.Runtime => 0x62c6282e => 117
	i32 1658251792, ; 102: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 78
	i32 1677501392, ; 103: System.Net.Primitives.dll => 0x63fca3d0 => 103
	i32 1679769178, ; 104: System.Security.Cryptography => 0x641f3e5a => 118
	i32 1729485958, ; 105: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 56
	i32 1743415430, ; 106: ca\Microsoft.Maui.Controls.resources => 0x67ea6886 => 1
	i32 1763938596, ; 107: System.Diagnostics.TraceSource.dll => 0x69239124 => 94
	i32 1766324549, ; 108: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 75
	i32 1770582343, ; 109: Microsoft.Extensions.Logging.dll => 0x6988f147 => 43
	i32 1780572499, ; 110: Mono.Android.Runtime.dll => 0x6a216153 => 130
	i32 1782862114, ; 111: ms\Microsoft.Maui.Controls.resources => 0x6a445122 => 17
	i32 1788241197, ; 112: Xamarin.AndroidX.Fragment => 0x6a96652d => 63
	i32 1793755602, ; 113: he\Microsoft.Maui.Controls.resources => 0x6aea89d2 => 9
	i32 1808609942, ; 114: Xamarin.AndroidX.Loader => 0x6bcd3296 => 68
	i32 1813058853, ; 115: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 79
	i32 1813201214, ; 116: Xamarin.Google.Android.Material => 0x6c13413e => 78
	i32 1818569960, ; 117: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 72
	i32 1824175904, ; 118: System.Text.Encoding.Extensions => 0x6cbab720 => 119
	i32 1824722060, ; 119: System.Runtime.Serialization.Formatters => 0x6cc30c8c => 115
	i32 1828688058, ; 120: Microsoft.Extensions.Logging.Abstractions.dll => 0x6cff90ba => 44
	i32 1853025655, ; 121: sv\Microsoft.Maui.Controls.resources => 0x6e72ed77 => 26
	i32 1858542181, ; 122: System.Linq.Expressions => 0x6ec71a65 => 99
	i32 1870277092, ; 123: System.Reflection.Primitives => 0x6f7a29e4 => 112
	i32 1875935024, ; 124: fr\Microsoft.Maui.Controls.resources => 0x6fd07f30 => 8
	i32 1893218855, ; 125: cs\Microsoft.Maui.Controls.resources.dll => 0x70d83a27 => 2
	i32 1910275211, ; 126: System.Collections.NonGeneric.dll => 0x71dc7c8b => 85
	i32 1939592360, ; 127: System.Private.Xml.Linq => 0x739bd4a8 => 108
	i32 1953182387, ; 128: id\Microsoft.Maui.Controls.resources.dll => 0x746b32b3 => 13
	i32 1968388702, ; 129: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 36
	i32 2003115576, ; 130: el\Microsoft.Maui.Controls.resources => 0x77651e38 => 5
	i32 2019465201, ; 131: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 66
	i32 2045470958, ; 132: System.Private.Xml => 0x79eb68ee => 109
	i32 2055257422, ; 133: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 65
	i32 2066184531, ; 134: de\Microsoft.Maui.Controls.resources => 0x7b277953 => 4
	i32 2070888862, ; 135: System.Diagnostics.TraceSource => 0x7b6f419e => 94
	i32 2079903147, ; 136: System.Runtime.dll => 0x7bf8cdab => 117
	i32 2090596640, ; 137: System.Numerics.Vectors => 0x7c9bf920 => 105
	i32 2127167465, ; 138: System.Console => 0x7ec9ffe9 => 91
	i32 2142473426, ; 139: System.Collections.Specialized => 0x7fb38cd2 => 86
	i32 2159891885, ; 140: Microsoft.Maui => 0x80bd55ad => 49
	i32 2169148018, ; 141: hu\Microsoft.Maui.Controls.resources => 0x814a9272 => 12
	i32 2181898931, ; 142: Microsoft.Extensions.Options.dll => 0x820d22b3 => 45
	i32 2192057212, ; 143: Microsoft.Extensions.Logging.Abstractions => 0x82a8237c => 44
	i32 2193016926, ; 144: System.ObjectModel.dll => 0x82b6c85e => 106
	i32 2201107256, ; 145: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 80
	i32 2201231467, ; 146: System.Net.Http => 0x8334206b => 102
	i32 2207618523, ; 147: it\Microsoft.Maui.Controls.resources => 0x839595db => 14
	i32 2266799131, ; 148: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 37
	i32 2279755925, ; 149: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 73
	i32 2303942373, ; 150: nb\Microsoft.Maui.Controls.resources => 0x89535ee5 => 18
	i32 2305521784, ; 151: System.Private.CoreLib.dll => 0x896b7878 => 128
	i32 2353062107, ; 152: System.Net.Primitives => 0x8c40e0db => 103
	i32 2366048013, ; 153: hu\Microsoft.Maui.Controls.resources.dll => 0x8d07070d => 12
	i32 2368005991, ; 154: System.Xml.ReaderWriter.dll => 0x8d24e767 => 125
	i32 2371007202, ; 155: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 36
	i32 2395872292, ; 156: id\Microsoft.Maui.Controls.resources => 0x8ece1c24 => 13
	i32 2401565422, ; 157: System.Web.HttpUtility => 0x8f24faee => 123
	i32 2427813419, ; 158: hi\Microsoft.Maui.Controls.resources => 0x90b57e2b => 10
	i32 2435356389, ; 159: System.Console.dll => 0x912896e5 => 91
	i32 2475788418, ; 160: Java.Interop.dll => 0x93918882 => 129
	i32 2480646305, ; 161: Microsoft.Maui.Controls => 0x93dba8a1 => 47
	i32 2503351294, ; 162: ko\Microsoft.Maui.Controls.resources.dll => 0x95361bfe => 16
	i32 2538310050, ; 163: System.Reflection.Emit.Lightweight.dll => 0x974b89a2 => 111
	i32 2550873716, ; 164: hr\Microsoft.Maui.Controls.resources => 0x980b3e74 => 11
	i32 2562349572, ; 165: Microsoft.CSharp => 0x98ba5a04 => 83
	i32 2576534780, ; 166: ja\Microsoft.Maui.Controls.resources.dll => 0x9992ccfc => 15
	i32 2585220780, ; 167: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 119
	i32 2593496499, ; 168: pl\Microsoft.Maui.Controls.resources => 0x9a959db3 => 20
	i32 2605712449, ; 169: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 80
	i32 2617129537, ; 170: System.Private.Xml.dll => 0x9bfe3a41 => 109
	i32 2620871830, ; 171: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 60
	i32 2626831493, ; 172: ja\Microsoft.Maui.Controls.resources => 0x9c924485 => 15
	i32 2664396074, ; 173: System.Xml.XDocument.dll => 0x9ecf752a => 126
	i32 2665622720, ; 174: System.Drawing.Primitives => 0x9ee22cc0 => 95
	i32 2676780864, ; 175: System.Data.Common.dll => 0x9f8c6f40 => 92
	i32 2690541537, ; 176: P06Shop.Shared => 0xa05e67e1 => 81
	i32 2724373263, ; 177: System.Runtime.Numerics.dll => 0xa262a30f => 114
	i32 2732626843, ; 178: Xamarin.AndroidX.Activity => 0xa2e0939b => 53
	i32 2737747696, ; 179: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 55
	i32 2740698338, ; 180: ca\Microsoft.Maui.Controls.resources.dll => 0xa35bbce2 => 1
	i32 2752995522, ; 181: pt-BR\Microsoft.Maui.Controls.resources => 0xa41760c2 => 21
	i32 2758225723, ; 182: Microsoft.Maui.Controls.Xaml => 0xa4672f3b => 48
	i32 2764765095, ; 183: Microsoft.Maui.dll => 0xa4caf7a7 => 49
	i32 2778768386, ; 184: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 76
	i32 2785988530, ; 185: th\Microsoft.Maui.Controls.resources => 0xa60ecfb2 => 27
	i32 2801831435, ; 186: Microsoft.Maui.Graphics => 0xa7008e0b => 51
	i32 2810250172, ; 187: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 58
	i32 2853208004, ; 188: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 76
	i32 2861189240, ; 189: Microsoft.Maui.Essentials => 0xaa8a4878 => 50
	i32 2909740682, ; 190: System.Private.CoreLib => 0xad6f1e8a => 128
	i32 2916838712, ; 191: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 77
	i32 2919462931, ; 192: System.Numerics.Vectors.dll => 0xae037813 => 105
	i32 2959614098, ; 193: System.ComponentModel.dll => 0xb0682092 => 90
	i32 2978675010, ; 194: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 62
	i32 3020703001, ; 195: Microsoft.Extensions.Diagnostics => 0xb40c4519 => 40
	i32 3038032645, ; 196: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 34
	i32 3053864966, ; 197: fi\Microsoft.Maui.Controls.resources.dll => 0xb6064806 => 7
	i32 3057625584, ; 198: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 69
	i32 3059408633, ; 199: Mono.Android.Runtime => 0xb65adef9 => 130
	i32 3059793426, ; 200: System.ComponentModel.Primitives => 0xb660be12 => 88
	i32 3159123045, ; 201: System.Reflection.Primitives.dll => 0xbc4c6465 => 112
	i32 3178803400, ; 202: Xamarin.AndroidX.Navigation.Fragment.dll => 0xbd78b0c8 => 70
	i32 3220365878, ; 203: System.Threading => 0xbff2e236 => 122
	i32 3258312781, ; 204: Xamarin.AndroidX.CardView => 0xc235e84d => 56
	i32 3305363605, ; 205: fi\Microsoft.Maui.Controls.resources => 0xc503d895 => 7
	i32 3316684772, ; 206: System.Net.Requests.dll => 0xc5b097e4 => 104
	i32 3317135071, ; 207: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 61
	i32 3346324047, ; 208: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 71
	i32 3357674450, ; 209: ru\Microsoft.Maui.Controls.resources => 0xc8220bd2 => 24
	i32 3362522851, ; 210: Xamarin.AndroidX.Core => 0xc86c06e3 => 59
	i32 3366347497, ; 211: Java.Interop => 0xc8a662e9 => 129
	i32 3374999561, ; 212: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 73
	i32 3381016424, ; 213: da\Microsoft.Maui.Controls.resources => 0xc9863768 => 3
	i32 3428513518, ; 214: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 38
	i32 3458724246, ; 215: pt\Microsoft.Maui.Controls.resources.dll => 0xce27f196 => 22
	i32 3471940407, ; 216: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 89
	i32 3476120550, ; 217: Mono.Android => 0xcf3163e6 => 131
	i32 3484440000, ; 218: ro\Microsoft.Maui.Controls.resources => 0xcfb055c0 => 23
	i32 3509114376, ; 219: System.Xml.Linq => 0xd128d608 => 124
	i32 3580758918, ; 220: zh-HK\Microsoft.Maui.Controls.resources => 0xd56e0b86 => 31
	i32 3592228221, ; 221: zh-Hant\Microsoft.Maui.Controls.resources.dll => 0xd61d0d7d => 33
	i32 3608519521, ; 222: System.Linq.dll => 0xd715a361 => 100
	i32 3641597786, ; 223: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 65
	i32 3643446276, ; 224: tr\Microsoft.Maui.Controls.resources => 0xd92a9404 => 28
	i32 3643854240, ; 225: Xamarin.AndroidX.Navigation.Fragment => 0xd930cda0 => 70
	i32 3657292374, ; 226: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 37
	i32 3672681054, ; 227: Mono.Android.dll => 0xdae8aa5e => 131
	i32 3724971120, ; 228: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 69
	i32 3748608112, ; 229: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 93
	i32 3751619990, ; 230: da\Microsoft.Maui.Controls.resources.dll => 0xdf9d2d96 => 3
	i32 3786282454, ; 231: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 57
	i32 3792276235, ; 232: System.Collections.NonGeneric => 0xe2098b0b => 85
	i32 3802395368, ; 233: System.Collections.Specialized.dll => 0xe2a3f2e8 => 86
	i32 3823082795, ; 234: System.Security.Cryptography.dll => 0xe3df9d2b => 118
	i32 3841636137, ; 235: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 39
	i32 3849253459, ; 236: System.Runtime.InteropServices.dll => 0xe56ef253 => 113
	i32 3896106733, ; 237: System.Collections.Concurrent.dll => 0xe839deed => 84
	i32 3896760992, ; 238: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 59
	i32 3920221145, ; 239: nl\Microsoft.Maui.Controls.resources.dll => 0xe9a9d3d9 => 19
	i32 3928044579, ; 240: System.Xml.ReaderWriter => 0xea213423 => 125
	i32 3931092270, ; 241: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 72
	i32 3955647286, ; 242: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 54
	i32 4025784931, ; 243: System.Memory => 0xeff49a63 => 101
	i32 4046471985, ; 244: Microsoft.Maui.Controls.Xaml.dll => 0xf1304331 => 48
	i32 4054681211, ; 245: System.Reflection.Emit.ILGeneration => 0xf1ad867b => 110
	i32 4068434129, ; 246: System.Private.Xml.Linq.dll => 0xf27f60d1 => 108
	i32 4073602200, ; 247: System.Threading.dll => 0xf2ce3c98 => 122
	i32 4091086043, ; 248: el\Microsoft.Maui.Controls.resources.dll => 0xf3d904db => 5
	i32 4094352644, ; 249: Microsoft.Maui.Essentials.dll => 0xf40add04 => 50
	i32 4099507663, ; 250: System.Drawing.dll => 0xf45985cf => 96
	i32 4100113165, ; 251: System.Private.Uri => 0xf462c30d => 107
	i32 4103439459, ; 252: uk\Microsoft.Maui.Controls.resources.dll => 0xf4958463 => 29
	i32 4126470640, ; 253: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 38
	i32 4147896353, ; 254: System.Reflection.Emit.ILGeneration.dll => 0xf73be021 => 110
	i32 4150914736, ; 255: uk\Microsoft.Maui.Controls.resources => 0xf769eeb0 => 29
	i32 4181436372, ; 256: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 116
	i32 4182413190, ; 257: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 67
	i32 4213026141, ; 258: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 93
	i32 4249188766, ; 259: nb\Microsoft.Maui.Controls.resources.dll => 0xfd45799e => 18
	i32 4271975918, ; 260: Microsoft.Maui.Controls.dll => 0xfea12dee => 47
	i32 4274623895, ; 261: CommunityToolkit.Mvvm.dll => 0xfec99597 => 35
	i32 4274976490, ; 262: System.Runtime.Numerics => 0xfecef6ea => 114
	i32 4292120959 ; 263: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 67
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [264 x i32] [
	i32 0, ; 0
	i32 52, ; 1
	i32 9, ; 2
	i32 121, ; 3
	i32 33, ; 4
	i32 51, ; 5
	i32 17, ; 6
	i32 41, ; 7
	i32 82, ; 8
	i32 113, ; 9
	i32 32, ; 10
	i32 25, ; 11
	i32 57, ; 12
	i32 75, ; 13
	i32 90, ; 14
	i32 40, ; 15
	i32 83, ; 16
	i32 111, ; 17
	i32 42, ; 18
	i32 30, ; 19
	i32 53, ; 20
	i32 8, ; 21
	i32 64, ; 22
	i32 121, ; 23
	i32 101, ; 24
	i32 34, ; 25
	i32 28, ; 26
	i32 87, ; 27
	i32 63, ; 28
	i32 123, ; 29
	i32 116, ; 30
	i32 127, ; 31
	i32 6, ; 32
	i32 106, ; 33
	i32 46, ; 34
	i32 27, ; 35
	i32 43, ; 36
	i32 81, ; 37
	i32 61, ; 38
	i32 19, ; 39
	i32 84, ; 40
	i32 124, ; 41
	i32 104, ; 42
	i32 98, ; 43
	i32 25, ; 44
	i32 45, ; 45
	i32 92, ; 46
	i32 107, ; 47
	i32 97, ; 48
	i32 10, ; 49
	i32 24, ; 50
	i32 88, ; 51
	i32 21, ; 52
	i32 52, ; 53
	i32 14, ; 54
	i32 64, ; 55
	i32 126, ; 56
	i32 23, ; 57
	i32 87, ; 58
	i32 74, ; 59
	i32 96, ; 60
	i32 39, ; 61
	i32 54, ; 62
	i32 95, ; 63
	i32 4, ; 64
	i32 99, ; 65
	i32 41, ; 66
	i32 66, ; 67
	i32 89, ; 68
	i32 79, ; 69
	i32 127, ; 70
	i32 26, ; 71
	i32 20, ; 72
	i32 16, ; 73
	i32 22, ; 74
	i32 71, ; 75
	i32 35, ; 76
	i32 82, ; 77
	i32 2, ; 78
	i32 62, ; 79
	i32 11, ; 80
	i32 100, ; 81
	i32 31, ; 82
	i32 32, ; 83
	i32 74, ; 84
	i32 58, ; 85
	i32 115, ; 86
	i32 0, ; 87
	i32 6, ; 88
	i32 98, ; 89
	i32 55, ; 90
	i32 46, ; 91
	i32 97, ; 92
	i32 42, ; 93
	i32 30, ; 94
	i32 120, ; 95
	i32 68, ; 96
	i32 77, ; 97
	i32 60, ; 98
	i32 102, ; 99
	i32 120, ; 100
	i32 117, ; 101
	i32 78, ; 102
	i32 103, ; 103
	i32 118, ; 104
	i32 56, ; 105
	i32 1, ; 106
	i32 94, ; 107
	i32 75, ; 108
	i32 43, ; 109
	i32 130, ; 110
	i32 17, ; 111
	i32 63, ; 112
	i32 9, ; 113
	i32 68, ; 114
	i32 79, ; 115
	i32 78, ; 116
	i32 72, ; 117
	i32 119, ; 118
	i32 115, ; 119
	i32 44, ; 120
	i32 26, ; 121
	i32 99, ; 122
	i32 112, ; 123
	i32 8, ; 124
	i32 2, ; 125
	i32 85, ; 126
	i32 108, ; 127
	i32 13, ; 128
	i32 36, ; 129
	i32 5, ; 130
	i32 66, ; 131
	i32 109, ; 132
	i32 65, ; 133
	i32 4, ; 134
	i32 94, ; 135
	i32 117, ; 136
	i32 105, ; 137
	i32 91, ; 138
	i32 86, ; 139
	i32 49, ; 140
	i32 12, ; 141
	i32 45, ; 142
	i32 44, ; 143
	i32 106, ; 144
	i32 80, ; 145
	i32 102, ; 146
	i32 14, ; 147
	i32 37, ; 148
	i32 73, ; 149
	i32 18, ; 150
	i32 128, ; 151
	i32 103, ; 152
	i32 12, ; 153
	i32 125, ; 154
	i32 36, ; 155
	i32 13, ; 156
	i32 123, ; 157
	i32 10, ; 158
	i32 91, ; 159
	i32 129, ; 160
	i32 47, ; 161
	i32 16, ; 162
	i32 111, ; 163
	i32 11, ; 164
	i32 83, ; 165
	i32 15, ; 166
	i32 119, ; 167
	i32 20, ; 168
	i32 80, ; 169
	i32 109, ; 170
	i32 60, ; 171
	i32 15, ; 172
	i32 126, ; 173
	i32 95, ; 174
	i32 92, ; 175
	i32 81, ; 176
	i32 114, ; 177
	i32 53, ; 178
	i32 55, ; 179
	i32 1, ; 180
	i32 21, ; 181
	i32 48, ; 182
	i32 49, ; 183
	i32 76, ; 184
	i32 27, ; 185
	i32 51, ; 186
	i32 58, ; 187
	i32 76, ; 188
	i32 50, ; 189
	i32 128, ; 190
	i32 77, ; 191
	i32 105, ; 192
	i32 90, ; 193
	i32 62, ; 194
	i32 40, ; 195
	i32 34, ; 196
	i32 7, ; 197
	i32 69, ; 198
	i32 130, ; 199
	i32 88, ; 200
	i32 112, ; 201
	i32 70, ; 202
	i32 122, ; 203
	i32 56, ; 204
	i32 7, ; 205
	i32 104, ; 206
	i32 61, ; 207
	i32 71, ; 208
	i32 24, ; 209
	i32 59, ; 210
	i32 129, ; 211
	i32 73, ; 212
	i32 3, ; 213
	i32 38, ; 214
	i32 22, ; 215
	i32 89, ; 216
	i32 131, ; 217
	i32 23, ; 218
	i32 124, ; 219
	i32 31, ; 220
	i32 33, ; 221
	i32 100, ; 222
	i32 65, ; 223
	i32 28, ; 224
	i32 70, ; 225
	i32 37, ; 226
	i32 131, ; 227
	i32 69, ; 228
	i32 93, ; 229
	i32 3, ; 230
	i32 57, ; 231
	i32 85, ; 232
	i32 86, ; 233
	i32 118, ; 234
	i32 39, ; 235
	i32 113, ; 236
	i32 84, ; 237
	i32 59, ; 238
	i32 19, ; 239
	i32 125, ; 240
	i32 72, ; 241
	i32 54, ; 242
	i32 101, ; 243
	i32 48, ; 244
	i32 110, ; 245
	i32 108, ; 246
	i32 122, ; 247
	i32 5, ; 248
	i32 50, ; 249
	i32 96, ; 250
	i32 107, ; 251
	i32 29, ; 252
	i32 38, ; 253
	i32 110, ; 254
	i32 29, ; 255
	i32 116, ; 256
	i32 67, ; 257
	i32 93, ; 258
	i32 18, ; 259
	i32 47, ; 260
	i32 35, ; 261
	i32 114, ; 262
	i32 67 ; 263
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ f1b7113872c8db3dfee70d11925e81bb752dc8d0"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"min_enum_size", i32 4}
