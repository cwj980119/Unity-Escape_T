> Written with [StackEdit](https://stackedit.io/).
> # Escape-T
> ## 목차
> 0. 게임 설명 PPT</br>
> 
> 1. 개요</br>

> 2. 스토리</br>

> 3. 게임 플레이 방식
```
  - 개요
  - 시작화면, 설정, 게임 기본 화면
  - 튜토리얼
  - 4층
  - 5층
  - 6층
  - 7층
  - 엔딩
```

> 4. 게임 동작 방식

	  - C# 스크립트를 활용한 동작
	  - Unity tool을 활용한 동작

> 5. 다운로드
> 6. 참조

> ## 0. 게임 설명 PPT
![001](https://user-images.githubusercontent.com/86039114/140431624-199a600d-81cf-46f8-9a2d-87629c559490.jpg)
![002](https://user-images.githubusercontent.com/86039114/140431684-55c314fd-5447-4a72-935e-4cf175c68f20.jpg)
![003](https://user-images.githubusercontent.com/86039114/140431696-85bbdcae-589d-41cc-adf4-6927b9c40e3c.jpg)
![004](https://user-images.githubusercontent.com/86039114/140431853-a17865e2-8f95-4778-bfae-1f5187709cfd.jpg)
![005](https://user-images.githubusercontent.com/86039114/140431857-866f1557-1467-419b-aad9-3445d68f69e9.jpg)
![006](https://user-images.githubusercontent.com/86039114/140431863-3b3a0765-b2d6-488b-b03e-06b6f5eafdea.jpg)
![007](https://user-images.githubusercontent.com/86039114/140431871-b1c6b4b4-68e2-415b-b65e-0696b1de4d86.jpg)
![008](https://user-images.githubusercontent.com/86039114/140431876-4b5daec7-4c11-4aa5-8ebf-a2bc685227ec.jpg)
![009](https://user-images.githubusercontent.com/86039114/140431878-2525d141-64c9-47e8-ad37-9fb1424d8827.jpg)

>
>- 게임 플레이 화면 ( 실제로는 마우스가 아닌 터치로 동작, 빠른 진행을 위해 2배속 녹화, 소리 O)
>

https://user-images.githubusercontent.com/86039114/140431993-a245744e-fb75-45a0-b12b-097e63098295.mp4

![011](https://user-images.githubusercontent.com/86039114/140432123-caf4108e-d065-4f8f-9796-8570a70dcb1b.jpg)
![녹화_2021_11_05_08_16_07_458](https://user-images.githubusercontent.com/86039114/140433159-9e15fd38-fc89-426d-a6e4-4590e76e0d16.gif)
![013](https://user-images.githubusercontent.com/86039114/140432564-cac5e3e8-c91e-4427-b612-2d99243ae268.jpg)
![014](https://user-images.githubusercontent.com/86039114/140432571-96c52c00-fdb8-4bbd-9c94-54bde68b210c.jpg)
![녹화_2021_11_05_08_05_34_847](https://user-images.githubusercontent.com/86039114/140432846-9e0f05cb-56d1-4507-8c86-3eef948bfd77.gif)
![녹화_2021_11_05_08_06_01_862](https://user-images.githubusercontent.com/86039114/140432896-a98bc5ab-6baa-4632-a3ff-3d16a9f50b18.gif)
![017](https://user-images.githubusercontent.com/86039114/140432905-fee74785-c652-4650-a0f3-6276020bebc1.jpg)
![018](https://user-images.githubusercontent.com/86039114/140432909-f6a1679b-5182-4105-8c88-cffcedcbe886.jpg)
![019](https://user-images.githubusercontent.com/86039114/140432914-169b3e14-02a9-49df-af6f-6f3c2bd64408.jpg)
![녹화_2021_11_05_08_06_27_599](https://user-images.githubusercontent.com/86039114/140432929-53470ea2-2a44-45b5-9dd6-27e3e88feb8d.gif)
![021](https://user-images.githubusercontent.com/86039114/140432944-b5795b26-1d2f-4af2-bf4c-6736b47d3236.jpg)
![022](https://user-images.githubusercontent.com/86039114/140432954-944b46c5-d0d1-4cfd-b18d-c364400c95ef.jpg)
![녹화_2021_11_05_08_06_52_540](https://user-images.githubusercontent.com/86039114/140432962-efe080cd-0fff-449a-8152-d3e192576c73.gif)
![024](https://user-images.githubusercontent.com/86039114/140432967-61cdc06a-b689-4782-877f-bc36c92b3d80.jpg)
![녹화_2021_11_05_08_07_15_834](https://user-images.githubusercontent.com/86039114/140432976-41c84a94-96be-4fba-91d7-ce8876486085.gif)
![026](https://user-images.githubusercontent.com/86039114/140432992-5c02eaa9-b008-4276-8113-986af5e9a510.jpg)
![027](https://user-images.githubusercontent.com/86039114/140432997-ff0e317e-dc16-421e-a551-a8dc80f4d627.jpg)
![녹화_2021_11_05_08_07_38_959](https://user-images.githubusercontent.com/86039114/140433004-e29ea6b3-c3d3-4ae1-8266-2ebb8b8074fc.gif)
![녹화_2021_11_05_08_07_59_769](https://user-images.githubusercontent.com/86039114/140433028-12c6d06d-1f99-4867-b621-65ae3643edf8.gif)
![030](https://user-images.githubusercontent.com/86039114/140433033-f6b3c0e6-df2a-4e2d-93b6-106fc5c8ee7e.jpg)
![031](https://user-images.githubusercontent.com/86039114/140433038-6d698c0d-c431-4b41-bec3-5b88b69408b0.jpg)
>

> ## 1. 개요
>-  Escape-T 게임은 어드벤처 게임과 퍼즐 게임의 일종인 방탈출 게임이다.
>- 방탈출 게임에 대한 자세한 설명은 [여기](https://ko.wikipedia.org/wiki/%ED%83%88%EC%B6%9C_%EA%B2%8C%EC%9E%84) 참조 바람.
>- Escape-T는 4개의 층에 다양한 퀴즈와 단서를 활용하여 각 층을 탈출해 최종 목표까지 가는 게임이다. 
>- Escape-T는 Unity엔진(2020.3.12버전)으로 개발되었다. 
>- 스크립트 언어는 C#으로 개발되었다.
>- 이 게임은 Android용 스마트폰에 맞춰 개발되었다. 즉, iOS 에서는 구동되지 않는다.

> ## 2. 스토리
> 졸업 프로젝트 발표 전날, 4학년 홍와우(캐릭터 이름)는 프로젝트 점검을 위해 홍익대학교 T동 8층으로 이동한다. 강의실 컴퓨터에 USB를 꽂는 순간, 천둥 번개 소리와 함께 기절을 하고...
> 깨어나 보니 자신은 4층 열람실에 쓰러져 있다. 시간은 벌써 새벽, 학교의 모든 문은 잠겨있다. 졸업 프로젝트 발표 시간 전까지 8층에 놓고 온 USB를 가지고 T동을 탈출하여 무사히 발표를 마칠 수 있을까? 여러분의 플레이에 달려있다.

>## 3. 게임 플레이 방식
>
>### (1) 개요
>- 1번 참조
>
>### (2) 시작화면, 게임 기본 화면, 인벤토리, 설정
>
>#### - 시작화면
>- 시작화면은 다음과 같이 구성되어 있다.
![StartScene](https://user-images.githubusercontent.com/80233719/139189500-6dd57141-9443-48bd-a855-6a60d9a875fc.jpg)
```
	- 새로시작 : 스토리 처음부터 게임을 진행 할 수 있다.
	- 이어하기 : 특정 층을 클리어 한 이후에는 이어하기를 이용하여 이전 층을 다시 플레이 할 수 있다.
	- 설정 : 게임의 효과음이나 배경음악을 끄고 켤 수 있다.
	- 크래딧 : 제작한 사람들의 이름을 확인 할 수 있다.
	- 종료하기: 게임을 종료한다.
```

>#### - 게임 기본 화면
>- 게임 기본 화면은 다음과 같이 구성되어 있다. (예시 화면이다.)
>![CommonScreen](https://user-images.githubusercontent.com/80233719/139191088-64ce1d06-cbca-4dd5-94fe-068b8f11ec26.jpg)
```
	- 1 인벤토리 : 인벤토리 창을 열 수 있다.(인벤토리 항목 참고)
	- 2 설정 : 설정창을 열 수 있다. (설정 항목 참고)
	- 3 조이스틱 : 게임 캐릭터를 움직일 수 있다.
	- 4 상호작용버튼 : 게임 중 문을 열거나 물건을 주울 수 있다.
	- 5 캐릭터(홍와우): 게임을 진행하는 캐릭터이다.
	- 6 물건 : 게임을 푸는 단서이다. 4를 통해 수집할 수 있다.
```

>#### - 인벤토리
>- 인벤토리 창은 다음과 같이 생겼다.
>
>![Inventory](https://user-images.githubusercontent.com/80233719/139191800-7173994e-c954-4494-9538-a727ab57a4cf.jpg)
>```
> 	- 1번 배낭 모양 버튼을 눌러 켤 수 있다.
> 	- 물건 근처에서 4번 손 모양 버튼을 누르면 위 이미지인 인벤토리 창에 저장이 된다.
> 	- 인벤토리 화면에서 물건을 클릭하면 큰 화면으로 볼 수 있다.
> 	- 다시 1번 버튼을 눌러 끌 수 있다.
>``` 	
>#### - 설정
>- 설정창은 다음과 같다.
![SettingPanel](https://user-images.githubusercontent.com/80233719/139190332-92e690f9-51ee-4ec3-81cd-7b17e9acb03d.jpg)
```
	- 배경음악 : 음표를 터치하여 배경음악을 끄고 켤 수 있다.
	- 효과음 : 음표를 터치하여 효과음을 끄고 켤 수 있다.
	- 뒤로가기 : 게임화면으로 돌아 갈 수 있다.
	- 메인 메뉴로 나가기 : 시작화면으로 돌아간다.
```
### (3) 튜토리얼
>	i. 맨 처음 제4공학관(T동) 앞에서 시작한다.
![tutorial1](https://user-images.githubusercontent.com/80233719/139273323-0da7514d-a000-4f73-8e31-72af8f8b8035.jpg)
>	ii. 8층으로 이동하여 졸업 프로젝트를 확인하기 위해 컴퓨터에 USB를 꽂는다.
![tutorial2](https://user-images.githubusercontent.com/80233719/139273831-ddea9c71-8903-43f9-938b-d96d4071dfdc.jpg)

### (4) 4층
>![4층](https://user-images.githubusercontent.com/80233719/139274518-8422ef0f-46e5-4ca8-a6d7-21531e8c553d.jpg)

### (5) 5층
> 5층 내용은 [여기](https://github.com/cwj980119/Unity-Escape_T/files/7435185/5.pdf)를 눌러 확인

### (6) 6층
>![6층](https://user-images.githubusercontent.com/80233719/139279510-96e63c29-1efc-42e5-8843-6bcad63afe1f.png)

### (7) 7층
>![7층](https://user-images.githubusercontent.com/80233719/139274835-b614b41d-1590-4186-ae2b-2556327b13ae.jpg)

### (8) 엔딩
>	- 8층까지 올라가서 다시 USB를 가져오고 T동을 탈출해 무사히 졸업 프로젝트를 발표하게 된다.
>![tutorial2](https://user-images.githubusercontent.com/80233719/139273831-ddea9c71-8903-43f9-938b-d96d4071dfdc.jpg)

## 4. 게임 동작 방식
> - 게임 구현 방식으로는 C# 스크립트를 활용한 것과 Unity 자체 Tool을 활용한 것이 있다.
> - 여기서는 자주 사용된 것 위주로 소개할 예정이다.

> ### (1) C# 스크립트를 활용한 동작
>#### i. 캐릭터 움직이기
> ![movement](https://user-images.githubusercontent.com/80233719/139282016-eca3cf8d-8e2c-4d95-befe-d2c207cb9ef6.jpg)
> - 여기서는 캐릭터 움직이기 뿐만이 아니라 캐릭터가 움직임이 있을 때만 소리가 나도록 구현이 되어있다.

> #### ii. 설정창
> ![setting1](https://user-images.githubusercontent.com/80233719/139282854-ee3fd743-8e66-4e38-a9c2-c6c095aef4d4.jpg)
![setting2](https://user-images.githubusercontent.com/80233719/139282863-b227442e-dd2a-4c77-89f2-d40713011ae7.jpg)
> - 설정 창의 주요 기능인 소리를 끄고 켜는 기능을 구현한 코드이다.

>#### iii. Scene Change
> ![scenechange](https://user-images.githubusercontent.com/80233719/139284278-385d809c-8ca5-487d-b54c-575f939e65a4.jpg)
> - 한 층에서 다른 층으로 이동할 때 사용된 코드이다.

>#### iv. 아이템과 인벤토리
>![invent](https://user-images.githubusercontent.com/80233719/139285209-15fb5b8e-5d2f-4609-beb3-f0f5dc3df41b.jpg)
> - 아이템과 인벤토리와 관련된 스크립트는 많으나 문서 분량 상 여기에서는 인벤토리 슬롯과 관련된 코드만 있다.
> - 더 자세히 코드를 보고 싶으면 https://github.com/cwj980119/Unity-Escape_T/tree/master/Escape_T/Assets/Scrpits/Inventory 에서 볼 수 있다.

>#### v. 도어락
>![keypad1](https://user-images.githubusercontent.com/80233719/139528992-01d26d3e-2c4a-4f79-ba69-1093fcffe5ec.jpg)
> - 5, 6, 7층에서 사용된 광 범위하게 사용된 코드이다.
> - 도어락의 번호를 눌러서 번호가 맞으면 OpenPanel이 열리게 하거나 문이 열리게 하는 코드이다.

>#### vi. 퀴즈 관련 코드
>![gamecontrol1](https://user-images.githubusercontent.com/80233719/139528584-dcc0da9a-2bde-4e80-8cc5-ee2cd3c3b81c.jpg)
>![gamecontrol2](https://user-images.githubusercontent.com/80233719/139528585-1ba17c5f-a426-4a36-9c22-540b7cc4ef38.jpg)
>![gamecontrol3](https://user-images.githubusercontent.com/80233719/139528589-df9592ff-c01f-4203-bbaf-d86711e73b63.jpg)

> - 여기서는 5층에 C++ 관련 퀴즈에 대한 코드 설명이다.
> - 위에서 첫번째, 두번째는 TouchRotation 코드이고, 터치하면 90도로 회전하게 만든 코드이다.
> - 맨 아래코드는 GameControl 코드이며, 이미지가 맞춰지면, 정답으로 판단해 로딩중이라는 텍스트를 활성화 시키고 힌트를 알려주는 화면을 활성화하는 코드이다.
> 
> ※ 예시 화면
> 
>![code1](https://user-images.githubusercontent.com/80233719/139528928-61ea5271-499c-46f6-801e-f0f7594a601f.jpg)
>![code2](https://user-images.githubusercontent.com/80233719/139528931-4a13fc41-883b-444b-8428-e30a50a384c1.jpg)
>![code3](https://user-images.githubusercontent.com/80233719/139528936-bd1df758-0e5c-4788-8ce8-2c0c401bdfa7.jpg)

> #### vii. 그 외
>  - 그 외 코드는 https://github.com/cwj980119/Unity-Escape_T/tree/master/Escape_T/Assets/Scrpits 에서 확인할 수 있다.

> ### (2) Unity Tool을 활용한 동작

> #### i. Canvas Scaler
> ![canvas scaler](https://user-images.githubusercontent.com/80233719/139285983-aaa32fd3-2559-48b2-bbeb-4c749b112f82.jpg)
> - 이 기능을 이용하여 다양한 스마트폰에서도 일정한 비율로 게임을 출력할 수 있다.

> #### ii. Button
> ![button](https://user-images.githubusercontent.com/80233719/139287408-2e6f883e-92aa-42b5-b7c4-9a95f9e0598a.jpg)
![button2](https://user-images.githubusercontent.com/80233719/139286756-e64f5b47-bc0b-44d8-9809-9f2ad8ae1075.jpg)
> - Button으로 키패드나 나가기 버튼 등을 개발하는 데 활용했다.

>#### iii. Prefab
>![prefab](https://user-images.githubusercontent.com/80233719/139287186-be647802-030a-4bdb-b6d3-3481742af1cc.jpg)
> - Prefab 기능을 활용하여 여러 곳에 사용되는 요소를 일괄적으로 관리 할 수 있게 되었다.

>#### iv. Box Collider
>![box collider](https://user-images.githubusercontent.com/80233719/139288188-a8136389-6098-436a-8090-aef4ed49c123.jpg)
![box collider2](https://user-images.githubusercontent.com/80233719/139288200-a2399a99-9a95-426e-9087-616e983aae34.jpg)
> - Box Collider을 이용하여 상호작용 장치로 이용하거나(Is Trigger), 벽처럼 통과하지 못하게 하는 기능을 구현했다.

>#### v. Animation
> ![animation1](https://user-images.githubusercontent.com/80233719/139289257-b40e2905-e8a5-403e-848e-8fd01328e375.jpg)
> ![animation2](https://user-images.githubusercontent.com/80233719/139289260-9aa32d51-1e1e-41a5-aa3f-56189b77a7a2.jpg)
> - Animation 기능으로 캐릭터 움직임을 구현했다.

>## 5. 다운로드
>- 게임 다운로드는 다음의 링크에서 가능하다.
>- https://drive.google.com/drive/u/1/folders/1l4YMKq9pvaw-OHnLOoMrP7oer1fXnUkn

>## 6. 참조
>- https://unitybeginner.tistory.com/
>- https://wergia.tistory.com/category/Unity3D
>- [유튜브 CodeMonkey](https://www.youtube.com/channel/UCFK6NCbuCIVzA6Yj1G_ZqCg)
>...
