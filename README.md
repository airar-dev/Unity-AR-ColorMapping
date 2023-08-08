<br />

<p align="center">
  <a href="https://github.com/airar-dev/ColorMapping">
    <img src="http://airar.co.kr/ColorMapping/Img/Default/logo_2023_N-01-W.png" alt="Logo" width="80" height="80">
  </a>

  <h1 align="center"> ColorMapping </h1>
  
<div align="center">
  
[![GitHub release (latest by date)](https://img.shields.io/github/v/release/airar-dev/Unity-AR-ColorMapping?color=4cc51e)](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/)
[![GitHub top language](https://img.shields.io/github/languages/top/airar-dev/Unity-AR-ColorMapping?color=1081c2)](https://github.com/airar-dev/Unity-AR-ColorMapping/search?l=c%23)
[![GitHub License](https://img.shields.io/github/license/airar-dev/Unity-AR-ColorMapping?color=f48041)](https://opensource.org/licenses/BSD-3-Clause)
[![GitHub Watchers](https://img.shields.io/github/watchers/airar-dev/Unity-AR-ColorMapping?color=4cc51e)](https://github.com/airar-dev/Unity-AR-ColorMapping/watchers)
[![GitHub Repo stars](https://img.shields.io/github/stars/airar-dev/Unity-AR-ColorMapping?color=4cc51e)](https://github.com/airar-dev/Unity-AR-ColorMapping/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/airar-dev/Unity-AR-ColorMapping?color=4cc51e)](https://github.com/airar-dev/Unity-AR-ColorMapping/network/members) <br />
[![Unity Badge](http://img.shields.io/badge/-Unity3D_2019.3.14f1-000?logo=unity&link=https://unity.com/)](https://unity.com/)
[![Visual Studio Badge](http://img.shields.io/badge/-Visual_Studio_2019-5C2D91?logo=visual-studio&link=https://visualstudio.microsoft.com/)](https://visualstudio.microsoft.com/)
[![OS And Badge](http://img.shields.io/badge/-opencv_3.4.10_android_sdk-3DDC84?logo=Android&logoColor=fff&link=https://opencv.org/releases/)](https://opencv.org/releases/)
[![OS IOS Badge](http://img.shields.io/badge/-opencv.framework-9f9f9f?logo=iOS&logoColor=fff&link=https://opencv.org/releases/)](https://opencv.org/releases/)

</div>

  <p align="center"> <br />
    This project is an easy-to-apply AR Coloring Library for Unity. <br />
    This project can be applied to AR Engines of MaxstAR, EasyAR, Vuforia, ARFoundation(ARkit, ARcore). <br />
    To use it for business projects, you need to purchase a separate license for the AR Engine. <br /><br />
    <a href="https://youtu.be/HaN_d2eDf2Q" target="_blank">View Demo</a> <br /><br />
    
 <p align="center">
  <a href="https://youtu.be/HaN_d2eDf2Q" rel="nofollow">
  <img src="http://airar.co.kr/ColorMapping/Img/Default/demo_video.gif" alt="demo video" style="max-width:100%;">
  </a>
 </p>
    
  </p>
</p>

<br />


## Table of Contents

* [Requirements](#requirements)
* [Installation](#installation)
* [Quick Start](#quick-start)
  * [with MaxstAR](#with-maxstar)
  * [with EasyAR](#with-easyar)
  * [with Vuforia](#with-vuforia)
  * [with ARFoundation(ARkit, ARcore)](#with-arfoundationarkit-arcore)
* [Release](#release)
* [Future Release](#Future-release)
* [Trouble Shooting](#Trouble-shooting)
* [Known Issues](#known-issues)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)

<br />


## Requirements

* Unity3D 2019.3.14f1
* MaxstAR 5.0.2v
* EasyAR 3.1.0v
* Vuforia Engine AR Unity Package 9.5.4v
* ARFoundation 2.1.8v
* Visual Studio 2019
* opencv-3.4.10-android-sdk
* opencv.framework(*3.4.11 version)<br />
  The opencv library can be downloaded from the official website. <br />Download the opencv from this link (https://opencv.org/releases/).<br /><br />
 
**\* As of August 3, 2021, the latest version of Unity3D and the latest version of each AR engine have been tested.**
  * Unity3D 2021.1.6f1
  * MaxstAR 5.0.5v
  * EasyAR 4.3.0v
  * Vuforia Engine AR Unity Package 10.0v
  * ARFoundation 4.1.7v<br /><br />

**\* As of July 21, 2023, the latest version of Unity3D and the latest version of each AR engine have been tested.**
  * Unity3D 2022.3.4f1
  * MaxstAR 6.0.1v
  * EasyAR 4.6.2v
  * Vuforia Engine AR Unity Package 10.16.3v
  * ARFoundation 5.0.6v

<br />


## Installation
　1. Clone a repository or download it as zip.
```
    git clone https://github.com/airar-dev/ColorMapping.git
```
　2. Importing the AR Engine SDK to be used together. <br />
　　(You can use MaxstAR, EasyAR, Vuforia, ARFoundation(ARkit, ARcore)) <br />

<br />


## Quick Start

### with MaxstAR

  **Create Android App Project Demo(https://youtu.be/JhixOsRKQ5k)**<br />
  **Create iOS App Project Demo(https://youtu.be/h3YQMaf7R-E)**<br /><br />

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />

　**2. Import [MaxstAR](https://developer.maxst.com/MD/downloadsdk)** <br />
 　-　Import MaxstAR SDK(5.0.2v +). <br /> <br />
  
　**3. Import Sample Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingWithMaxstARSample.unitypackage from <br />
　　 ColorMapping-master -> Sample folder.<br /> <br />

　**4. Import Native Library** <br />
　-　Import ‘libAirarColorMap.so, libopencv_java3.so’ file for Android. <br />
　 　(Set the CPU to ARM64 in the platform settings of the libAirarColorMap.so, libopencv_java3.so files.) <br />
　-　Import ‘libAirarColorMap.a, opencv2.framework’ file for iOS. <br /> <br />
 
　**5. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add ‘USE_MAXSTAR’ into Scripting Define Symbols</td></tr>
</table>
<br />

　**6. Player Settings for iOS**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add ‘USE_MAXSTAR’ into Scripting Define Symbols</td></tr>
</table>
<br />

　**7. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material <br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**8. MaxstARColorMapping.cs** <br /><br />
![masxtar-1]
<table>
<tr><td>trackableBehaviour　　</td><td>MaxstAR ImageTrackableBehaviour</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**9. Build** <br />
　-　Build by selecting the MaxstARSample scene under ColorMapping -> Scenes.<br /><br /><br />
 
 
### with EasyAR

  **Create Android App Project Demo(https://youtu.be/elk7-E3LDYc)**<br />

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Initialize [EasyAR](https://www.easyar.com/view/download.html)** <br />
　-　EasyAR 3.1.0 Version + required. <br />
　-　For EasyAR to work, a license key is required. <br /> <br />
 
　**3. Import Sample Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingWithEasyARSample.unitypackage from<br />
　　 ColorMapping-master -> Sample folder.<br /> <br />
 
　**4. Import Native Library** <br />
　-　Import ‘libAirarColorMap.so, libopencv_java3.so’ file for Android. <br />
　 　(Set the CPU to ARM64 in the platform settings of the libAirarColorMap.so, libopencv_java3.so files.) <br />
　-　Import ‘libAirarColorMap.a, opencv2.framework’ file for iOS. <br /> <br /> 
 
　**5. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Graphics APIs</td><td>Remove Vulkan from the Graphic API list</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_EASYAR' into Scripting Define Symbols</td></tr>
</table>
<br />

　**6. Player Settings for iOS**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Graphics APIs</td><td>Remove Metal from the Graphic API list</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Architecture</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_EASYAR' into Scripting Define Symbols</td></tr>
</table>
<br />

　**7. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material <br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**8. EasyARColorMapping.cs** <br /><br />
![easyar-1]
<table>
<tr><td>ImageTargetController　</td><td>EasyAR ImageTargetController</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**9. Build** <br />
　-　Build by selecting the EasyARSample scene under ColorMapping -> Scenes.<br /><br /><br />
 

### with Vuforia

  **Create Android App Project Demo(https://youtu.be/b5zSwDiwE4Q)**<br />

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import Vuforia Unity Package** <br />
 　-　Importing the Vuforia Engine AR Unity Package(9.5.4v +). <br /> <br />

　**3. Import Sample Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingWithVuforiaSample.unitypackage from <br />
　　 ColorMapping-master -> Sample folder.<br /><br />
 
　**4. Import Native Library** <br />
 　-　Import ‘libAirarColorMap.so, libopencv_java3.so’ file for Android. <br />
 　 　(Set the CPU to ARM64 in the platform settings of the libAirarColorMap.so, libopencv_java3.so files.) <br />
 　-　Import ‘libAirarColorMap.a, opencv2.framework’ file for iOS. <br /> <br />
 
　**5. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_VUFORIA' into Scripting Define Symbols</td></tr>
</table>
<br />

　**6. Player Settings for iOS**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_VUFORIA' into Scripting Define Symbols</td></tr>
</table>
<br />

　**7. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material <br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**8. VuforiaColorMapping.cs** <br /><br />
![vuforia-1]
<table>
<tr><td>ImageTaget　　　　　　</td><td>Vuforia ImageTargetBehaviour</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**9. Build** <br />
　-　Build by selecting the VuforiaSample scene under ColorMapping -> Scenes.<br /><br /><br />


### with ARFoundation(ARkit, ARcore)

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import ARFoundation Unity Package** <br />
　-　Importing the ARFoundation(2.1.8v +), <br />
　　 ARCore(for Android)(2.1.11v +), ARKit(for iOS)(2.1.9v +) Unity Package. <br /> <br />
  
　**3. Import Sample Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingWithARFoundationSample.unitypackage from <br />
　　 ColorMapping-master -> Sample folder.<br /><br />
  
　**4. Import Native Library** <br />
　-　Import ‘libAirarColorMap.so, libopencv_java3.so’ file for Android. <br />
　 　(Set the CPU to ARM64 in the platform settings of the libAirarColorMap.so, libopencv_java3.so files.) <br />
　-　Import ‘libAirarColorMap.a, opencv2.framework’ file for iOS. <br /><br />
 
　**5. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_ARFOUNDATION' into Scripting Define Symbols</td></tr>
<tr><td>Minimum API Level</td><td>Android 7.0(API Level 24)+</td></tr>
</table>
<br />

　**6. Player Settings for iOS**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Architecture</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_ARFOUNDATION' into Scripting Define Symbols</td></tr>
<tr><td>Target minimum iOS Version</td><td>11.0+</td></tr>
</table>
<br />

　**7. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material <br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**8. ARFoundationColorMapping.cs** <br /><br />
![arfoundation-1]
<table>
<tr><td>ImageManager　　　　</td><td>ARTrackedImageManager</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**7. Build** <br />
　-　Build by selecting the ARFoundationSample scene under ColorMapping -> Scenes.<br /><br /><br />
 

## Release
| Version | New Features | Date |
|:---:|---|:---:|
| 　v1.3.4　 | [the latest version of Unity3D and the latest version of each AR engine have been tested.](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.3.4) | 　2023.07.21　 |
| 　v1.3.3　 | [Upload samples compatible with the latest version of Vuforia](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.3.3) | 　2023.05.31　 |
| 　v1.3.2　 | [Upload samples compatible with the latest version of Vuforia](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.3.2) | 　2022.11.30　 |
| 　v1.3.1　 | [the latest version of Unity3D and the latest version of each AR engine have been tested.](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.3.1) | 　2021.08.03　 |
| 　v1.3.0　 | [update all sample for Android/iOS](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.3.0) | 　2020.10.27　 |
| 　v1.2.1　 | [modify sample unitypackages for android](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.2.1) | 　2020.10.23　 |
| v1.2.0 | [update android sample](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/v1.2.0) | 2020.10.23 |
| v1.1.0 | [add iOS Library](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/3) | 2020.10.21 |
| v1.0.1 | [add EasyAR sample](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/2) | 2020.10.07 |
| v1.0.0 | [Apply MaxstAR, EasyAR](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/v1.0.0) | 2020.09.09 |

<br />


## Future Release
* We will add a method for creating coloring 3D content in the near future.

<br />


## Trouble Shooting
* If an error such as "Undefined symbols for architecture arm64" occurs.
<br />
　　example:
<br />

```
 Undefined symbols for architecture arm64:
 "cv::getPerspectiveTransform(cv::Point_<float> const*, cv::Point_<float> const*)", referenced from:
 _ImageProc in libAirarColorMap.a(AirarColorMap.o)
 (maybe you meant: cv::getPerspectiveTransform(cv::Point_<float> const*, cv::Point_<float> const*, int))
 ld: symbol(s) not found for architecture arm64
 clang: error: linker command failed with exit code 1 (use -v to see invocation) 
```
  <br />
　　solutions: 
  <br />

　　Be sure to use **version 3.4.11 of the opencv framework.**
<br /><br />

## Known issues

* The coloring is not very accurate when used with the MaxstAR engine.

<br />


## Contributing

* Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated. <br /><br />
　1.　Fork the Project. <br />
　2.　Create your Feature Branch. <br />
　3.　Commit your Changes. <br />
　4.　Push to the Branch. <br />
　5.　Open a Pull Request. <br />

<br />


## License
* The 3-Clause BSD License. (see the LICENSE file inside this repo)

<br />

## Contact
* oh@airar.co (sung hoon oh)

<br /><br />


<!-- MARKDOWN LINKS & IMAGES -->
[masxtar-1]: http://airar.co.kr/ColorMapping/Img/MaxstARSampleImg_01.jpg
[easyar-1]: http://airar.co.kr/ColorMapping/Img/EasyARSampleImg_01.jpg
[vuforia-1]: http://airar.co.kr/ColorMapping/Img/VuforiaSampleImg_01_221130.jpg
[arfoundation-1]: http://airar.co.kr/ColorMapping/Img/ARFoundationSampleImg_01.jpg
