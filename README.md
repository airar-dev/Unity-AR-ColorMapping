<br />

<p align="center">
  <a href="https://github.com/airar-dev/ColorMapping">
    <img src="http://dev.airar.co/ColorMapping/Img/Default/logo_png.png" alt="Logo" width="80" height="80">
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
  <img src="http://dev.airar.co/ColorMapping/Img/Default/demo_video.gif" alt="demo video" style="max-width:100%;">
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
  * [with ARFoundation(ARkit, ARcore)](#with-arfoundation(arkit/arcore))
* [Release](#release)
* [Future Release](#Future-release)
* [Known Issues](#known-issues)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)

<br />


## Requirements

* Unity3d 2019.3.14f1
* Visual Studio 2019
* opencv-3.4.10-android-sdk
* opencv.framework

<br />


## Installation
　1.　Clone a repository or download it as zip.
```
    git clone https://github.com/airar-dev/ColorMapping.git
```
　2.　Download [OpenCV](https://opencv.org/releases/). <br />
　　　Add **libopencv_java3.so** into the Android folder and <br />
　　　add **opencv.framework** into the iOS folder. <br />
　　　(libopencv_java3.so location is under the path opencv-3.4.10-android-sdk\sdk\native\libs\armeabi-v7a) <br />
   
　　　![installation-1]

　3.　Importing the AR Engine SDK to be used together. <br />
　　　(You can use MaxstAR, EasyAR, Vuforia, ARFoundation(ARkit, ARcore)) <br />

<br />


## Quick Start

#### with MaxstAR

　1.　Create an empty Unity project.<br />
　2.　After extracting the downloaded file, <br />
　　　import ColorMappingMaxstARSample.unitypackage from <br />
　　　ColorMapping-master -> Sample -> MaxstARSample folder.<br />
　3.　Find the Allow 'unsafe' code setting (under the Other Settings category of Player Settings) and enable it.<br />
　4.　Add 'USE_MAXSTAR' into Scripting Define Symbols(under the Other Settings category of Player Settings).<br />
　5.　Build by selecting the MaxstARSample scene under ColorMapping -> Scenes. <br /><br />
  ![masxtar-1]
  MaxstARColorMapping.cs <br />
　-　ARContents:  3D object to augment <br />
　-　DrawObj: Object containing the material to which the colored texture is applied <br />
　-　RealWidth: Actual horizontal size of the marker image <br />
　-　RealHeight: Actual vertical size of the marker image <br />
<br /><br />
  ![masxtar-2]
  AirarManager.cs <br />
　-　Trasparent Mat: Transparent Material <br /><br />


#### with EasyAR

　1.　Create an empty Unity project.<br />
　2.　After extracting the downloaded file, <br />
　　　import ColorMappingEasyARSample.unitypackage from <br />
　　　ColorMapping-master -> Sample -> EasyARSample folder.<br />
　3.　Find the Allow 'unsafe' code setting (under the Other Settings category of Player Settings) and enable it.<br />
　4.　Add 'USE_EASYAR' into Scripting Define Symbols(under the Other Settings category of Player Settings).<br />
　5.　Build by selecting the EasyARSample scene under ColorMapping -> Scenes. <br /><br />
  ![easyar-1]
  EasyARColorMapping.cs <br />
　-　ARContents:  3D object to augment <br />
　-　DrawObj: Object containing the material to which the colored texture is applied <br />
　-　RealWidth: Actual horizontal size of the marker image <br />
　-　RealHeight: Actual vertical size of the marker image <br />
<br /><br />
  ![easyar-2]
  AirarManager.cs <br />
　-　Trasparent Mat: Transparent Material <br /><br />


#### with Vuforia

　1.　Create an empty Unity project.<br />
　2.　After extracting the downloaded file, <br />
　　　import ColorMappingEasyARSample.unitypackage from <br />
　　　ColorMapping-master -> Sample -> VuforiaSample folder.<br />
　3.　Find the Allow 'unsafe' code setting (under the Other Settings category of Player Settings) and enable it.<br />
　4.　Add 'USE_VUFORIA' into Scripting Define Symbols(under the Other Settings category of Player Settings). <br />
　5.　Build by selecting the VuforiaSample scene under ColorMapping -> Scenes. <br /><br />
  ![vuforia-1]
  VuforiaColorMapping.cs <br />
　-　ARContents:  3D object to augment <br />
　-　DrawObj: Object containing the material to which the colored texture is applied <br />
　-　RealWidth: Actual horizontal size of the marker image <br />
　-　RealHeight: Actual vertical size of the marker image <br />
<br /><br />
  ![vuforia-2]
  AirarManager.cs <br />
　-　Trasparent Mat: Transparent Material <br /><br />


## Release
| Version | New Features | Date |
|:---:|---|:---:|
| v1.1.0 | [add iOS Library](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/3) | 2020.10.21 |
| v1.0.1 | [add EasyAR sample](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/2) | 2020.10.07 |
| v1.0.0 | [Apply MaxstAR, EasyAR](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/v1.0.0) | 2020.09.09 |

<br />


## Future Release
* Scheduled to upload sample project using ARFoundation(ARkit, ARcore).
* Coming soon to upload sample project for ios.

<br />


## Known issues

* The coloring is not very accurate when used with the MaxstAR engine.
* ios is not yet supported.

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

[installation-1]: http://dev.airar.co/ColorMapping/Img/Default/Installation_01.jpg
[masxtar-1]: http://dev.airar.co/ColorMapping/Img/MaxstAR/MaxstARSampleImg_01.jpg
[masxtar-2]: http://dev.airar.co/ColorMapping/Img/MaxstAR/MaxstARSampleImg_02.jpg
[easyar-1]: http://dev.airar.co/ColorMapping/Img/EasyAR/EasyARSampleImg_01.jpg
[easyar-2]: http://dev.airar.co/ColorMapping/Img/EasyAR/EasyARSampleImg_02.jpg
[vuforia-1]: http://dev.airar.co/ColorMapping/Img/Vuforia/VuforiaSampleImg_01.jpg
[vuforia-2]: http://dev.airar.co/ColorMapping/Img/Vuforia/VuforiaSampleImg_02.jpg
