; ModuleID = 'marshal_methods.x86_64.ll'
source_filename = "marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [132 x ptr] zeroinitializer, align 16

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [264 x i64] [
	i64 98382396393917666, ; 0: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 46
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 131
	i64 131669012237370309, ; 2: Microsoft.Maui.Essentials.dll => 0x1d3c844de55c3c5 => 50
	i64 196720943101637631, ; 3: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 99
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 57
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 74
	i64 560278790331054453, ; 6: System.Reflection.Primitives => 0x7c6829760de3975 => 112
	i64 750875890346172408, ; 7: System.Threading.Thread => 0xa6ba5a4da7d1ff8 => 121
	i64 799765834175365804, ; 8: System.ComponentModel.dll => 0xb1956c9f18442ac => 90
	i64 805302231655005164, ; 9: hu\Microsoft.Maui.Controls.resources.dll => 0xb2d021ceea03bec => 12
	i64 872800313462103108, ; 10: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 62
	i64 1010599046655515943, ; 11: System.Reflection.Primitives.dll => 0xe065e7a82401d27 => 112
	i64 1120440138749646132, ; 12: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 78
	i64 1268860745194512059, ; 13: System.Drawing.dll => 0x119be62002c19ebb => 96
	i64 1369545283391376210, ; 14: Xamarin.AndroidX.Navigation.Fragment.dll => 0x13019a2dd85acb52 => 70
	i64 1476839205573959279, ; 15: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 103
	i64 1486715745332614827, ; 16: Microsoft.Maui.Controls.dll => 0x14a1e017ea87d6ab => 47
	i64 1513467482682125403, ; 17: Mono.Android.Runtime => 0x1500eaa8245f6c5b => 130
	i64 1537168428375924959, ; 18: System.Threading.Thread.dll => 0x15551e8a954ae0df => 121
	i64 1624659445732251991, ; 19: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 55
	i64 1628611045998245443, ; 20: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 67
	i64 1731380447121279447, ; 21: Newtonsoft.Json => 0x18071957e9b889d7 => 52
	i64 1743969030606105336, ; 22: System.Memory.dll => 0x1833d297e88f2af8 => 101
	i64 1767386781656293639, ; 23: System.Private.Uri.dll => 0x188704e9f5582107 => 107
	i64 1795316252682057001, ; 24: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 54
	i64 1835311033149317475, ; 25: es\Microsoft.Maui.Controls.resources => 0x197855a927386163 => 6
	i64 1836611346387731153, ; 26: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 74
	i64 1875417405349196092, ; 27: System.Drawing.Primitives => 0x1a06d2319b6c713c => 95
	i64 1881198190668717030, ; 28: tr\Microsoft.Maui.Controls.resources => 0x1a1b5bc992ea9be6 => 28
	i64 1920760634179481754, ; 29: Microsoft.Maui.Controls.Xaml => 0x1aa7e99ec2d2709a => 48
	i64 1930726298510463061, ; 30: CommunityToolkit.Mvvm.dll => 0x1acb5156cd389055 => 35
	i64 1981742497975770890, ; 31: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 66
	i64 2102659300918482391, ; 32: System.Drawing.Primitives.dll => 0x1d2e257e6aead5d7 => 95
	i64 2133195048986300728, ; 33: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 52
	i64 2262844636196693701, ; 34: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 62
	i64 2287834202362508563, ; 35: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 84
	i64 2329709569556905518, ; 36: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 65
	i64 2470498323731680442, ; 37: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 58
	i64 2497223385847772520, ; 38: System.Runtime => 0x22a7eb7046413568 => 117
	i64 2547086958574651984, ; 39: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 53
	i64 2602673633151553063, ; 40: th\Microsoft.Maui.Controls.resources => 0x241e8de13a460e27 => 27
	i64 2656907746661064104, ; 41: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 38
	i64 2662981627730767622, ; 42: cs\Microsoft.Maui.Controls.resources => 0x24f4cfae6c48af06 => 2
	i64 2895129759130297543, ; 43: fi\Microsoft.Maui.Controls.resources => 0x282d912d479fa4c7 => 7
	i64 3017704767998173186, ; 44: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 78
	i64 3289520064315143713, ; 45: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 64
	i64 3311221304742556517, ; 46: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 105
	i64 3325875462027654285, ; 47: System.Runtime.Numerics => 0x2e27e21c8958b48d => 114
	i64 3344514922410554693, ; 48: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 80
	i64 3429672777697402584, ; 49: Microsoft.Maui.Essentials => 0x2f98a5385a7b1ed8 => 50
	i64 3494946837667399002, ; 50: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 36
	i64 3522470458906976663, ; 51: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 75
	i64 3551103847008531295, ; 52: System.Private.CoreLib.dll => 0x31480e226177735f => 128
	i64 3567343442040498961, ; 53: pt\Microsoft.Maui.Controls.resources => 0x3181bff5bea4ab11 => 22
	i64 3571415421602489686, ; 54: System.Runtime.dll => 0x319037675df7e556 => 117
	i64 3638003163729360188, ; 55: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 37
	i64 3647754201059316852, ; 56: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 125
	i64 3655542548057982301, ; 57: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 36
	i64 3727469159507183293, ; 58: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 73
	i64 3869221888984012293, ; 59: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 43
	i64 3890352374528606784, ; 60: Microsoft.Maui.Controls.Xaml.dll => 0x35fd4edf66e00240 => 48
	i64 3933965368022646939, ; 61: System.Net.Requests => 0x369840a8bfadc09b => 104
	i64 3966267475168208030, ; 62: System.Memory => 0x370b03412596249e => 101
	i64 4009997192427317104, ; 63: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 116
	i64 4070326265757318011, ; 64: da\Microsoft.Maui.Controls.resources.dll => 0x387cb42c56683b7b => 3
	i64 4073500526318903918, ; 65: System.Private.Xml.dll => 0x3887fb25779ae26e => 109
	i64 4120493066591692148, ; 66: zh-Hant\Microsoft.Maui.Controls.resources => 0x392eee9cdda86574 => 33
	i64 4154383907710350974, ; 67: System.ComponentModel => 0x39a7562737acb67e => 90
	i64 4187479170553454871, ; 68: System.Linq.Expressions => 0x3a1cea1e912fa117 => 99
	i64 4205801962323029395, ; 69: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 89
	i64 4360412976914417659, ; 70: tr\Microsoft.Maui.Controls.resources.dll => 0x3c834c8002fcc7fb => 28
	i64 4477672992252076438, ; 71: System.Web.HttpUtility.dll => 0x3e23e3dcdb8ba196 => 123
	i64 4657212095206026001, ; 72: Microsoft.Extensions.Http.dll => 0x40a1bdb9c2686b11 => 42
	i64 4794310189461587505, ; 73: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 53
	i64 4795410492532947900, ; 74: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 75
	i64 4809057822547766521, ; 75: System.Drawing => 0x42bd349c3145ecf9 => 96
	i64 4871824391508510238, ; 76: nb\Microsoft.Maui.Controls.resources.dll => 0x439c3278d7f2c61e => 18
	i64 4953714692329509532, ; 77: sv\Microsoft.Maui.Controls.resources.dll => 0x44bf21444aef129c => 26
	i64 5103417709280584325, ; 78: System.Collections.Specialized => 0x46d2fb5e161b6285 => 86
	i64 5182934613077526976, ; 79: System.Collections.Specialized.dll => 0x47ed7b91fa9009c0 => 86
	i64 5471532531798518949, ; 80: sv\Microsoft.Maui.Controls.resources => 0x4beec9d926d82ca5 => 26
	i64 5522859530602327440, ; 81: uk\Microsoft.Maui.Controls.resources => 0x4ca5237b51eead90 => 29
	i64 5570799893513421663, ; 82: System.IO.Compression.Brotli => 0x4d4f74fcdfa6c35f => 97
	i64 5573260873512690141, ; 83: System.Security.Cryptography.dll => 0x4d58333c6e4ea1dd => 118
	i64 5692067934154308417, ; 84: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 77
	i64 6010974535988770325, ; 85: Microsoft.Extensions.Diagnostics.dll => 0x536b457e33877615 => 40
	i64 6200764641006662125, ; 86: ro\Microsoft.Maui.Controls.resources => 0x560d8a96830131ed => 23
	i64 6284145129771520194, ; 87: System.Reflection.Emit.ILGeneration => 0x5735c4b3610850c2 => 110
	i64 6300676701234028427, ; 88: es\Microsoft.Maui.Controls.resources.dll => 0x57708013cda25f8b => 6
	i64 6357457916754632952, ; 89: _Microsoft.Android.Resource.Designer => 0x583a3a4ac2a7a0f8 => 34
	i64 6401687960814735282, ; 90: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 65
	i64 6471714727257221498, ; 91: fi\Microsoft.Maui.Controls.resources.dll => 0x59d026417dd4a97a => 7
	i64 6478287442656530074, ; 92: hr\Microsoft.Maui.Controls.resources => 0x59e7801b0c6a8e9a => 11
	i64 6548213210057960872, ; 93: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 61
	i64 6560151584539558821, ; 94: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 45
	i64 6743165466166707109, ; 95: nl\Microsoft.Maui.Controls.resources => 0x5d948943c08c43a5 => 19
	i64 6786606130239981554, ; 96: System.Diagnostics.TraceSource => 0x5e2ede51877147f2 => 94
	i64 6814185388980153342, ; 97: System.Xml.XDocument.dll => 0x5e90d98217d1abfe => 126
	i64 6876862101832370452, ; 98: System.Xml.Linq => 0x5f6f85a57d108914 => 124
	i64 6894844156784520562, ; 99: System.Numerics.Vectors => 0x5faf683aead1ad72 => 105
	i64 7083547580668757502, ; 100: System.Private.Xml.Linq.dll => 0x624dd0fe8f56c5fe => 108
	i64 7270811800166795866, ; 101: System.Linq => 0x64e71ccf51a90a5a => 100
	i64 7377312882064240630, ; 102: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 89
	i64 7488575175965059935, ; 103: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 124
	i64 7489048572193775167, ; 104: System.ObjectModel => 0x67ee71ff6b419e3f => 106
	i64 7654504624184590948, ; 105: System.Net.Http => 0x6a3a4366801b8264 => 102
	i64 7714652370974252055, ; 106: System.Private.CoreLib => 0x6b0ff375198b9c17 => 128
	i64 7735176074855944702, ; 107: Microsoft.CSharp => 0x6b58dda848e391fe => 83
	i64 7735352534559001595, ; 108: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 79
	i64 7742555799473854801, ; 109: it\Microsoft.Maui.Controls.resources.dll => 0x6b73157a51479951 => 14
	i64 7836164640616011524, ; 110: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 55
	i64 7884152814776082997, ; 111: P06Shop.Shared.dll => 0x6d6a2336879fe235 => 81
	i64 7892773303745881112, ; 112: P08Library.MAUI => 0x6d88c3808675a418 => 82
	i64 7919757340696389605, ; 113: Microsoft.Extensions.Diagnostics.Abstractions => 0x6de8a157378027e5 => 41
	i64 7975724199463739455, ; 114: sk\Microsoft.Maui.Controls.resources.dll => 0x6eaf76e6f785e03f => 25
	i64 8064050204834738623, ; 115: System.Collections.dll => 0x6fe942efa61731bf => 87
	i64 8083354569033831015, ; 116: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 64
	i64 8087206902342787202, ; 117: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 93
	i64 8108129031893776750, ; 118: ko\Microsoft.Maui.Controls.resources.dll => 0x7085dc65530f796e => 16
	i64 8167236081217502503, ; 119: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 129
	i64 8185542183669246576, ; 120: System.Collections => 0x7198e33f4794aa70 => 87
	i64 8246048515196606205, ; 121: Microsoft.Maui.Graphics.dll => 0x726fd96f64ee56fd => 51
	i64 8368701292315763008, ; 122: System.Security.Cryptography => 0x7423997c6fd56140 => 118
	i64 8386351099740279196, ; 123: zh-HK\Microsoft.Maui.Controls.resources.dll => 0x74624de475b9d19c => 31
	i64 8400357532724379117, ; 124: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 72
	i64 8410671156615598628, ; 125: System.Reflection.Emit.Lightweight.dll => 0x74b8b4daf4b25224 => 111
	i64 8563666267364444763, ; 126: System.Private.Uri => 0x76d841191140ca5b => 107
	i64 8626175481042262068, ; 127: Java.Interop => 0x77b654e585b55834 => 129
	i64 8638972117149407195, ; 128: Microsoft.CSharp.dll => 0x77e3cb5e8b31d7db => 83
	i64 8639588376636138208, ; 129: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 71
	i64 8677882282824630478, ; 130: pt-BR\Microsoft.Maui.Controls.resources => 0x786e07f5766b00ce => 21
	i64 8725526185868997716, ; 131: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 93
	i64 8816904670177563593, ; 132: Microsoft.Extensions.Diagnostics => 0x7a5bf015646a93c9 => 40
	i64 8941376889969657626, ; 133: System.Xml.XDocument => 0x7c1626e87187471a => 126
	i64 9045785047181495996, ; 134: zh-HK\Microsoft.Maui.Controls.resources => 0x7d891592e3cb0ebc => 31
	i64 9312692141327339315, ; 135: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 77
	i64 9324707631942237306, ; 136: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 54
	i64 9363564275759486853, ; 137: el\Microsoft.Maui.Controls.resources.dll => 0x81f21019382e9785 => 5
	i64 9551379474083066910, ; 138: uk\Microsoft.Maui.Controls.resources.dll => 0x848d5106bbadb41e => 29
	i64 9659729154652888475, ; 139: System.Text.RegularExpressions => 0x860e407c9991dd9b => 120
	i64 9678050649315576968, ; 140: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 58
	i64 9702891218465930390, ; 141: System.Collections.NonGeneric.dll => 0x86a79827b2eb3c96 => 85
	i64 9773637193738963987, ; 142: ca\Microsoft.Maui.Controls.resources.dll => 0x87a2ef3ea85b4c13 => 1
	i64 9808709177481450983, ; 143: Mono.Android.dll => 0x881f890734e555e7 => 131
	i64 9956195530459977388, ; 144: Microsoft.Maui => 0x8a2b8315b36616ac => 49
	i64 10038780035334861115, ; 145: System.Net.Http.dll => 0x8b50e941206af13b => 102
	i64 10051358222726253779, ; 146: System.Private.Xml => 0x8b7d990c97ccccd3 => 109
	i64 10092835686693276772, ; 147: Microsoft.Maui.Controls => 0x8c10f49539bd0c64 => 47
	i64 10143853363526200146, ; 148: da\Microsoft.Maui.Controls.resources => 0x8cc634e3c2a16b52 => 3
	i64 10209869394718195525, ; 149: nl\Microsoft.Maui.Controls.resources.dll => 0x8db0be1ecb4f7f45 => 19
	i64 10229024438826829339, ; 150: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 61
	i64 10245369515835430794, ; 151: System.Reflection.Emit.Lightweight => 0x8e2edd4ad7fc978a => 111
	i64 10364469296367737616, ; 152: System.Reflection.Emit.ILGeneration.dll => 0x8fd5fde967711b10 => 110
	i64 10406448008575299332, ; 153: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 80
	i64 10430153318873392755, ; 154: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 59
	i64 10506226065143327199, ; 155: ca\Microsoft.Maui.Controls.resources => 0x91cd9cf11ed169df => 1
	i64 10761706286639228993, ; 156: zh-Hant\Microsoft.Maui.Controls.resources.dll => 0x955942d988382841 => 33
	i64 10785150219063592792, ; 157: System.Net.Primitives => 0x95ac8cfb68830758 => 103
	i64 11002576679268595294, ; 158: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 44
	i64 11009005086950030778, ; 159: Microsoft.Maui.dll => 0x98c7d7cc621ffdba => 49
	i64 11103970607964515343, ; 160: hu\Microsoft.Maui.Controls.resources => 0x9a193a6fc41a6c0f => 12
	i64 11156122287428000958, ; 161: th\Microsoft.Maui.Controls.resources.dll => 0x9ad2821cdcf6dcbe => 27
	i64 11157797727133427779, ; 162: fr\Microsoft.Maui.Controls.resources.dll => 0x9ad875ea9172e843 => 8
	i64 11162124722117608902, ; 163: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 76
	i64 11220793807500858938, ; 164: ja\Microsoft.Maui.Controls.resources => 0x9bb8448481fdd63a => 15
	i64 11226290749488709958, ; 165: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 45
	i64 11340910727871153756, ; 166: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 60
	i64 11485890710487134646, ; 167: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 113
	i64 11518296021396496455, ; 168: id\Microsoft.Maui.Controls.resources => 0x9fd9353475222047 => 13
	i64 11529969570048099689, ; 169: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 76
	i64 11530571088791430846, ; 170: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 43
	i64 11855031688536399763, ; 171: vi\Microsoft.Maui.Controls.resources.dll => 0xa485888294361f93 => 30
	i64 12201331334810686224, ; 172: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 116
	i64 12451044538927396471, ; 173: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 63
	i64 12466513435562512481, ; 174: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 68
	i64 12475113361194491050, ; 175: _Microsoft.Android.Resource.Designer.dll => 0xad2081818aba1caa => 34
	i64 12517810545449516888, ; 176: System.Diagnostics.TraceSource.dll => 0xadb8325e6f283f58 => 94
	i64 12538491095302438457, ; 177: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 56
	i64 12550732019250633519, ; 178: System.IO.Compression => 0xae2d28465e8e1b2f => 98
	i64 12700543734426720211, ; 179: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 57
	i64 12708922737231849740, ; 180: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 119
	i64 12843321153144804894, ; 181: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 46
	i64 12989346753972519995, ; 182: ar\Microsoft.Maui.Controls.resources.dll => 0xb4436e0d5ee7c43b => 0
	i64 13005833372463390146, ; 183: pt-BR\Microsoft.Maui.Controls.resources.dll => 0xb47e008b5d99ddc2 => 21
	i64 13068258254871114833, ; 184: System.Runtime.Serialization.Formatters.dll => 0xb55bc7a4eaa8b451 => 115
	i64 13343850469010654401, ; 185: Mono.Android.Runtime.dll => 0xb92ee14d854f44c1 => 130
	i64 13381594904270902445, ; 186: he\Microsoft.Maui.Controls.resources => 0xb9b4f9aaad3e94ad => 9
	i64 13465488254036897740, ; 187: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 79
	i64 13540124433173649601, ; 188: vi\Microsoft.Maui.Controls.resources => 0xbbe82f6eede718c1 => 30
	i64 13572454107664307259, ; 189: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 73
	i64 13717397318615465333, ; 190: System.ComponentModel.Primitives.dll => 0xbe5dfc2ef2f87d75 => 88
	i64 13881769479078963060, ; 191: System.Console.dll => 0xc0a5f3cade5c6774 => 91
	i64 13959074834287824816, ; 192: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 63
	i64 14124974489674258913, ; 193: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 56
	i64 14125464355221830302, ; 194: System.Threading.dll => 0xc407bafdbc707a9e => 122
	i64 14254574811015963973, ; 195: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 119
	i64 14349907877893689639, ; 196: ro\Microsoft.Maui.Controls.resources.dll => 0xc7251d2f956ed127 => 23
	i64 14461014870687870182, ; 197: System.Net.Requests.dll => 0xc8afd8683afdece6 => 104
	i64 14464374589798375073, ; 198: ru\Microsoft.Maui.Controls.resources => 0xc8bbc80dcb1e5ea1 => 24
	i64 14491877563792607819, ; 199: zh-Hans\Microsoft.Maui.Controls.resources.dll => 0xc91d7ddcee4fca4b => 32
	i64 14610046442689856844, ; 200: cs\Microsoft.Maui.Controls.resources.dll => 0xcac14fd5107d054c => 2
	i64 14622043554576106986, ; 201: System.Runtime.Serialization.Formatters => 0xcaebef2458cc85ea => 115
	i64 14669215534098758659, ; 202: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 38
	i64 14690985099581930927, ; 203: System.Web.HttpUtility => 0xcbe0dd1ca5233daf => 123
	i64 14705122255218365489, ; 204: ko\Microsoft.Maui.Controls.resources => 0xcc1316c7b0fb5431 => 16
	i64 14735017007120366644, ; 205: ja\Microsoft.Maui.Controls.resources.dll => 0xcc7d4be604bfbc34 => 15
	i64 14744092281598614090, ; 206: zh-Hans\Microsoft.Maui.Controls.resources => 0xcc9d89d004439a4a => 32
	i64 14852515768018889994, ; 207: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 60
	i64 14904040806490515477, ; 208: ar\Microsoft.Maui.Controls.resources => 0xced5ca2604cb2815 => 0
	i64 14954917835170835695, ; 209: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 39
	i64 14987728460634540364, ; 210: System.IO.Compression.dll => 0xcfff1ba06622494c => 98
	i64 15051741671811457419, ; 211: Microsoft.Extensions.Diagnostics.Abstractions.dll => 0xd0e2874d8f44218b => 41
	i64 15076659072870671916, ; 212: System.ObjectModel.dll => 0xd13b0d8c1620662c => 106
	i64 15111608613780139878, ; 213: ms\Microsoft.Maui.Controls.resources => 0xd1b737f831192f66 => 17
	i64 15115185479366240210, ; 214: System.IO.Compression.Brotli.dll => 0xd1c3ed1c1bc467d2 => 97
	i64 15133485256822086103, ; 215: System.Linq.dll => 0xd204f0a9127dd9d7 => 100
	i64 15203009853192377507, ; 216: pt\Microsoft.Maui.Controls.resources.dll => 0xd2fbf0e9984b94a3 => 22
	i64 15227001540531775957, ; 217: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 37
	i64 15370334346939861994, ; 218: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 59
	i64 15391712275433856905, ; 219: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 39
	i64 15527772828719725935, ; 220: System.Console => 0xd77dbb1e38cd3d6f => 91
	i64 15536481058354060254, ; 221: de\Microsoft.Maui.Controls.resources => 0xd79cab34eec75bde => 4
	i64 15582737692548360875, ; 222: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 67
	i64 15609085926864131306, ; 223: System.dll => 0xd89e9cf3334914ea => 127
	i64 15661133872274321916, ; 224: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 125
	i64 15783653065526199428, ; 225: el\Microsoft.Maui.Controls.resources => 0xdb0accd674b1c484 => 5
	i64 16056281320585338352, ; 226: ru\Microsoft.Maui.Controls.resources.dll => 0xded35eca8f3a9df0 => 24
	i64 16154507427712707110, ; 227: System => 0xe03056ea4e39aa26 => 127
	i64 16285388671246273370, ; 228: P06Shop.Shared => 0xe20152b67ace0b5a => 81
	i64 16288847719894691167, ; 229: nb\Microsoft.Maui.Controls.resources => 0xe20d9cb300c12d5f => 18
	i64 16321164108206115771, ; 230: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 44
	i64 16558262036769511634, ; 231: Microsoft.Extensions.Http => 0xe5cac397cf7b98d2 => 42
	i64 16648892297579399389, ; 232: CommunityToolkit.Mvvm => 0xe70cbf55c4f508dd => 35
	i64 16649148416072044166, ; 233: Microsoft.Maui.Graphics => 0xe70da84600bb4e86 => 51
	i64 16677317093839702854, ; 234: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 72
	i64 16803648858859583026, ; 235: ms\Microsoft.Maui.Controls.resources.dll => 0xe9328d9b8ab93632 => 17
	i64 16856067890322379635, ; 236: System.Data.Common.dll => 0xe9ecc87060889373 => 92
	i64 16890310621557459193, ; 237: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 120
	i64 16942731696432749159, ; 238: sk\Microsoft.Maui.Controls.resources => 0xeb20acb622a01a67 => 25
	i64 16998075588627545693, ; 239: Xamarin.AndroidX.Navigation.Fragment => 0xebe54bb02d623e5d => 70
	i64 17008137082415910100, ; 240: System.Collections.NonGeneric => 0xec090a90408c8cd4 => 85
	i64 17031351772568316411, ; 241: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 69
	i64 17062143951396181894, ; 242: System.ComponentModel.Primitives => 0xecc8e986518c9786 => 88
	i64 17203614576212522419, ; 243: pl\Microsoft.Maui.Controls.resources.dll => 0xeebf844ef3e135b3 => 20
	i64 17230721278011714856, ; 244: System.Private.Xml.Linq => 0xef1fd1b5c7a72d28 => 108
	i64 17260702271250283638, ; 245: System.Data.Common => 0xef8a5543bba6bc76 => 92
	i64 17310278548634113468, ; 246: hi\Microsoft.Maui.Controls.resources.dll => 0xf03a76a04e6695bc => 10
	i64 17342750010158924305, ; 247: hi\Microsoft.Maui.Controls.resources => 0xf0add33f97ecc211 => 10
	i64 17514990004910432069, ; 248: fr\Microsoft.Maui.Controls.resources => 0xf311be9c6f341f45 => 8
	i64 17623389608345532001, ; 249: pl\Microsoft.Maui.Controls.resources => 0xf492db79dfbef661 => 20
	i64 17704177640604968747, ; 250: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 68
	i64 17710060891934109755, ; 251: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 66
	i64 17712670374920797664, ; 252: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 113
	i64 17777860260071588075, ; 253: System.Runtime.Numerics.dll => 0xf6b7a5b72419c0eb => 114
	i64 17827813215687577648, ; 254: hr\Microsoft.Maui.Controls.resources.dll => 0xf7691da9f3129030 => 11
	i64 17942426894774770628, ; 255: de\Microsoft.Maui.Controls.resources.dll => 0xf9004e329f771bc4 => 4
	i64 18025913125965088385, ; 256: System.Threading => 0xfa28e87b91334681 => 122
	i64 18121036031235206392, ; 257: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 69
	i64 18245806341561545090, ; 258: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 84
	i64 18305135509493619199, ; 259: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 71
	i64 18324163916253801303, ; 260: it\Microsoft.Maui.Controls.resources => 0xfe4c81ff0a56ab57 => 14
	i64 18342408478508122430, ; 261: id\Microsoft.Maui.Controls.resources.dll => 0xfe8d53543697013e => 13
	i64 18358161419737137786, ; 262: he\Microsoft.Maui.Controls.resources.dll => 0xfec54a8ba8b6827a => 9
	i64 18364471556821264070 ; 263: P08Library.MAUI.dll => 0xfedbb594f018a6c6 => 82
], align 16

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [264 x i32] [
	i32 46, ; 0
	i32 131, ; 1
	i32 50, ; 2
	i32 99, ; 3
	i32 57, ; 4
	i32 74, ; 5
	i32 112, ; 6
	i32 121, ; 7
	i32 90, ; 8
	i32 12, ; 9
	i32 62, ; 10
	i32 112, ; 11
	i32 78, ; 12
	i32 96, ; 13
	i32 70, ; 14
	i32 103, ; 15
	i32 47, ; 16
	i32 130, ; 17
	i32 121, ; 18
	i32 55, ; 19
	i32 67, ; 20
	i32 52, ; 21
	i32 101, ; 22
	i32 107, ; 23
	i32 54, ; 24
	i32 6, ; 25
	i32 74, ; 26
	i32 95, ; 27
	i32 28, ; 28
	i32 48, ; 29
	i32 35, ; 30
	i32 66, ; 31
	i32 95, ; 32
	i32 52, ; 33
	i32 62, ; 34
	i32 84, ; 35
	i32 65, ; 36
	i32 58, ; 37
	i32 117, ; 38
	i32 53, ; 39
	i32 27, ; 40
	i32 38, ; 41
	i32 2, ; 42
	i32 7, ; 43
	i32 78, ; 44
	i32 64, ; 45
	i32 105, ; 46
	i32 114, ; 47
	i32 80, ; 48
	i32 50, ; 49
	i32 36, ; 50
	i32 75, ; 51
	i32 128, ; 52
	i32 22, ; 53
	i32 117, ; 54
	i32 37, ; 55
	i32 125, ; 56
	i32 36, ; 57
	i32 73, ; 58
	i32 43, ; 59
	i32 48, ; 60
	i32 104, ; 61
	i32 101, ; 62
	i32 116, ; 63
	i32 3, ; 64
	i32 109, ; 65
	i32 33, ; 66
	i32 90, ; 67
	i32 99, ; 68
	i32 89, ; 69
	i32 28, ; 70
	i32 123, ; 71
	i32 42, ; 72
	i32 53, ; 73
	i32 75, ; 74
	i32 96, ; 75
	i32 18, ; 76
	i32 26, ; 77
	i32 86, ; 78
	i32 86, ; 79
	i32 26, ; 80
	i32 29, ; 81
	i32 97, ; 82
	i32 118, ; 83
	i32 77, ; 84
	i32 40, ; 85
	i32 23, ; 86
	i32 110, ; 87
	i32 6, ; 88
	i32 34, ; 89
	i32 65, ; 90
	i32 7, ; 91
	i32 11, ; 92
	i32 61, ; 93
	i32 45, ; 94
	i32 19, ; 95
	i32 94, ; 96
	i32 126, ; 97
	i32 124, ; 98
	i32 105, ; 99
	i32 108, ; 100
	i32 100, ; 101
	i32 89, ; 102
	i32 124, ; 103
	i32 106, ; 104
	i32 102, ; 105
	i32 128, ; 106
	i32 83, ; 107
	i32 79, ; 108
	i32 14, ; 109
	i32 55, ; 110
	i32 81, ; 111
	i32 82, ; 112
	i32 41, ; 113
	i32 25, ; 114
	i32 87, ; 115
	i32 64, ; 116
	i32 93, ; 117
	i32 16, ; 118
	i32 129, ; 119
	i32 87, ; 120
	i32 51, ; 121
	i32 118, ; 122
	i32 31, ; 123
	i32 72, ; 124
	i32 111, ; 125
	i32 107, ; 126
	i32 129, ; 127
	i32 83, ; 128
	i32 71, ; 129
	i32 21, ; 130
	i32 93, ; 131
	i32 40, ; 132
	i32 126, ; 133
	i32 31, ; 134
	i32 77, ; 135
	i32 54, ; 136
	i32 5, ; 137
	i32 29, ; 138
	i32 120, ; 139
	i32 58, ; 140
	i32 85, ; 141
	i32 1, ; 142
	i32 131, ; 143
	i32 49, ; 144
	i32 102, ; 145
	i32 109, ; 146
	i32 47, ; 147
	i32 3, ; 148
	i32 19, ; 149
	i32 61, ; 150
	i32 111, ; 151
	i32 110, ; 152
	i32 80, ; 153
	i32 59, ; 154
	i32 1, ; 155
	i32 33, ; 156
	i32 103, ; 157
	i32 44, ; 158
	i32 49, ; 159
	i32 12, ; 160
	i32 27, ; 161
	i32 8, ; 162
	i32 76, ; 163
	i32 15, ; 164
	i32 45, ; 165
	i32 60, ; 166
	i32 113, ; 167
	i32 13, ; 168
	i32 76, ; 169
	i32 43, ; 170
	i32 30, ; 171
	i32 116, ; 172
	i32 63, ; 173
	i32 68, ; 174
	i32 34, ; 175
	i32 94, ; 176
	i32 56, ; 177
	i32 98, ; 178
	i32 57, ; 179
	i32 119, ; 180
	i32 46, ; 181
	i32 0, ; 182
	i32 21, ; 183
	i32 115, ; 184
	i32 130, ; 185
	i32 9, ; 186
	i32 79, ; 187
	i32 30, ; 188
	i32 73, ; 189
	i32 88, ; 190
	i32 91, ; 191
	i32 63, ; 192
	i32 56, ; 193
	i32 122, ; 194
	i32 119, ; 195
	i32 23, ; 196
	i32 104, ; 197
	i32 24, ; 198
	i32 32, ; 199
	i32 2, ; 200
	i32 115, ; 201
	i32 38, ; 202
	i32 123, ; 203
	i32 16, ; 204
	i32 15, ; 205
	i32 32, ; 206
	i32 60, ; 207
	i32 0, ; 208
	i32 39, ; 209
	i32 98, ; 210
	i32 41, ; 211
	i32 106, ; 212
	i32 17, ; 213
	i32 97, ; 214
	i32 100, ; 215
	i32 22, ; 216
	i32 37, ; 217
	i32 59, ; 218
	i32 39, ; 219
	i32 91, ; 220
	i32 4, ; 221
	i32 67, ; 222
	i32 127, ; 223
	i32 125, ; 224
	i32 5, ; 225
	i32 24, ; 226
	i32 127, ; 227
	i32 81, ; 228
	i32 18, ; 229
	i32 44, ; 230
	i32 42, ; 231
	i32 35, ; 232
	i32 51, ; 233
	i32 72, ; 234
	i32 17, ; 235
	i32 92, ; 236
	i32 120, ; 237
	i32 25, ; 238
	i32 70, ; 239
	i32 85, ; 240
	i32 69, ; 241
	i32 88, ; 242
	i32 20, ; 243
	i32 108, ; 244
	i32 92, ; 245
	i32 10, ; 246
	i32 10, ; 247
	i32 8, ; 248
	i32 20, ; 249
	i32 68, ; 250
	i32 66, ; 251
	i32 113, ; 252
	i32 114, ; 253
	i32 11, ; 254
	i32 4, ; 255
	i32 122, ; 256
	i32 69, ; 257
	i32 84, ; 258
	i32 71, ; 259
	i32 14, ; 260
	i32 13, ; 261
	i32 9, ; 262
	i32 82 ; 263
], align 16

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 8

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 8

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 8

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
	store ptr %fn, ptr @get_function_pointer, align 8, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 16

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }

; Metadata
!llvm.module.flags = !{!0, !1}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ f1b7113872c8db3dfee70d11925e81bb752dc8d0"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
