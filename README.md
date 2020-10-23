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
  * [with ARFoundation(ARkit, ARcore)](#with-arfoundationarkit-arcore)
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
　1. Clone a repository or download it as zip.
```
    git clone https://github.com/airar-dev/ColorMapping.git
```
　2. Importing the AR Engine SDK to be used together. <br />
　　(You can use MaxstAR, EasyAR, Vuforia, ARFoundation(ARkit, ARcore)) <br />

<br />


## Quick Start

### with MaxstAR

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingEasyARSample.unitypackage from<br />
　　 ColorMapping-master -> Sample -> android folder.<br /> <br />
 
　**3. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add ‘USE_MAXSTAR’ into Scripting Define Symbols</td></tr>
</table>
<br />

　**4. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material<br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**5. Initialize MaxstAR** <br />
　-　For MaxstAR to work, a license key is required.<br /><br />
 
　**6. MaxstARColorMapping.cs** <br /><br />
![masxtar-1]
<table>
<tr><td>trackableBehaviour　　</td><td>MaxstAR ImageTrackableBehaviour</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**7. Build** <br />
　-　Build by selecting the MaxstARSample scene under ColorMapping -> Scenes.<br /><br /><br />
 
 
### with EasyAR

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingEasyARSample.unitypackage from<br />
　　 ColorMapping-master -> Sample -> android folder.<br /> <br />
 
　**3. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Graphics APIs</td><td>Remove Vulkan from the Graphic API list</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_EASYAR' into Scripting Define Symbols</td></tr>
</table>
<br />

　**4. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material<br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**5. Initialize EasyAR** <br />
　-　For EasyAR to work, a license key is required.<br /><br />
 
　**6. EasyARColorMapping.cs** <br /><br />
![easyar-1]
<table>
<tr><td>ImageTargetController　</td><td>EasyAR ImageTargetController</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**7. Build** <br />
　-　Build by selecting the EasyARSample scene under ColorMapping -> Scenes.<br /><br /><br />
 

### with Vuforia

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingVuforiaSample.unitypackage from ColorMapping-master -> Sample -> android folder.<br /><br />
 
　**3. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_VUFORIA' into Scripting Define Symbols</td></tr>
</table>
<br />

　**4. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material<br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**5. Initialize Vuforia** <br />
　-　For Vuforia to work, a license key is required.<br /><br />
 
　**6. VuforiaColorMapping.cs** <br /><br />
![vuforia-1]
<table>
<tr><td>ImageTaget　　　　　　</td><td>Vuforia ImageTargetBehaviour</td></tr>
<tr><td>ARContents</td><td>3D object to augment</td></tr>
<tr><td>RealWidth</td><td>Actual horizontal size of the marker image</td></tr>
<tr><td>RealHeight</td><td>Actual vertical size of the marker image</td></tr>
</table>
<br />
 
 　**7. Build** <br />
　-　Build by selecting the VuforiaSample scene under ColorMapping -> Scenes.<br /><br /><br />


### with ARFoundation(ARkit, ARcore)

　**1. Create Project** <br />
 　-　Create an empty Unity3D project. <br /> <br />
  
　**2. Import Package** <br />
　-　After extracting the downloaded file, <br />
　　 import ColorMappingARFoundationSample.unitypackage from<br />
　　 ColorMapping-master -> Sample -> android folder.<br /><br />
 
　**3. Player Settings for Android**
<table>
<tr><td>Allow 'unsafe' code</td><td>Check the Allow 'unsafe' code</td></tr>
<tr><td>Graphics APIs</td><td>Remove Vulkan from the Graphic API list</td></tr>
<tr><td>Scripting Backend</td><td>Select IL2CPP</td></tr>
<tr><td>Target Architectures</td><td>Check Arm64 architecture(uncheck ARM7)</td></tr>
<tr><td>Scripting Define Symbols</td><td>Add 'USE_ARFOUNDATION' into Scripting Define Symbols</td></tr>
<tr><td>Minimum API Level</td><td>Android 7.0(API Level 24)+</td></tr>
</table>
<br />

　**4. Setting for 3D Contents**
<table>
<tr> <td>‘coloring’ tag　　　　　</td><td>Set ‘coloring’ tag for Object containing the material<br/> to which the colored texture is applied</td></tr>
</table>
<br />

　**5. Initialize ARFoundation** <br />
　-　Importing the ARFoundation, ARCore, ARKit Unity Package.<br /><br />
 
　**6. ARFoundationColorMapping.cs** <br /><br />
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
| 　v1.2.1　 | [modify sample unitypackages for android](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/1.2.1) | 　2020.10.23　 |
| v1.2.0 | [update android sample](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/v1.2.0) | 2020.10.23 |
| v1.1.0 | [add iOS Library](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/3) | 2020.10.21 |
| v1.0.1 | [add EasyAR sample](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/2) | 2020.10.07 |
| v1.0.0 | [Apply MaxstAR, EasyAR](https://github.com/airar-dev/Unity-AR-ColorMapping/releases/tag/v1.0.0) | 2020.09.09 |

<br />


## Future Release
* Coming soon to upload sample project for ios.

<br />


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
[masxtar-1]: http://dev.airar.co/ColorMapping/Img/MaxstARSampleImg_01.jpg
[easyar-1]: http://dev.airar.co/ColorMapping/Img/EasyARSampleImg_01.jpg
[vuforia-1]: http://dev.airar.co/ColorMapping/Img/VuforiaSampleImg_01.jpg
[arfoundation-1]: http://dev.airar.co/ColorMapping/Img/ARFoundationSampleImg_01.jpg

