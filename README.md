# ColorMapping
<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/airar-dev/ColorMapping">
    <img src="http://dev.airar.co/ColorMapping/logo_png.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">ColorMapping</h3>

  <p align="center">
    이 프로젝트는 MaxstAR, EasyAR, Vuforia, ARkit, ARcore 에 적용가능한 AR 컬러링 라이브러리 입니다.
    <br />
   <a href="https://www.youtube.com/watch?v=I-WvBQRE2dw&feature=youtu.be">View Demo</a>
   
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Installation](#installation)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://www.youtube.com/watch?v=I-WvBQRE2dw&feature=youtu.be)


### Built With

* Unity3d 2019.3.14f1
* Visual Studio 2019
* opencv-3.4.10-android-sdk



<!-- GETTING STARTED -->
## Getting Started

ZIP 파일 다운로드후 알맞은 곳에 압축해제 후 유니티3d로 프로젝트 열기

### Installation
 
1. Clone the repo or just download
```sh
git clone https://github.com/airar-dev/ColorMapping.git
```

2. AR 엔진 탑재

MaxstAR, EasyAR, Vuforia, ARkit, ARcore 중에 적용할 엔진 임포트 


<!-- USAGE EXAMPLES -->
## Usage

with EasyAR

1. 프로젝트에 EasyAR SDK를 임포트합니다.

2. 씬에 'AirarManager.cs' 스크립트를 추가합니다.
[easyar-sc-1]
3. 씬에 EasyAR의 ImageTracking_Targets 프리팹을 추가합니다.

4. 추가한 ImageTracking_Targets 오브젝트 최상위에 'EasyARColorMapping.cs'스크립트를 추가합니다.

- ImageTargetController: ImageTracking_Targets 오브젝트
- AR Contents: 증강시킬 3D 오브젝트
- Draw Obj: 컬러링한 Texture를 입힐 Material이 포함된 오브젝트
- Trasparent Mat: 투명한 Material
- Real Height: 마커 이미지의 실제 세로 사이즈
- Real Width: 마커 이미지의 실제 가로 사이즈

with MaxstAR

1. 프로젝트에 MaxstAR SDK를 임포트합니다.

2. 씬에 'AirarManager.cs' 스크립트를 추가합니다.

. 씬에 EasyAR의 ImageTrackable 프리팹을 추가합니다.

4. 추가한 ImageTrackable 오브젝트 최상위에 'MaxstARColorMapping.cs'스크립트를 추가합니다.

- ImageTargetController: ImageTrackable 오브젝트
- AR Contents: 증강시킬 3D 오브젝트
- Draw Obj: 컬러링한 Texture를 입힐 Material이 포함된 오브젝트
- Trasparent Mat: 투명한 Material



_For more examples, please refer to the [Documentation](http://airar.co.kr)_



<!-- ROADMAP -->
## Roadmap

- apply EasyAR
- apply MaxstAR
- apply arfoundation

See the [open issues](https://github.com/airar-dev/ColorMapping/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact
sung hoon oh - oh@airar.co - email


<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

* []()
* []()
* []()





<!-- MARKDOWN LINKS & IMAGES -->

[product-screenshot]: http://dev.airar.co/ColorMapping/sample_0.gif
[easyar-sc-1]: http://dev.airar.co/ColorMapping/easyar/screenshot_01.png
[easyar-sc-2]: http://dev.airar.co/ColorMapping/easyar/screenshot_02.png
