> Written with [StackEdit](https://stackedit.io/).
> # Escape-T
> ## 목차
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
> - 더 자세히 코드를 보고 싶으면 https://github.com/cwj980119/Unity-Escape_T/tree/1012/Escape_T/Assets/Scrpits/Inventory 에서 볼 수 있다.

> #### v. 그 외
>  - 그 외 코드는 https://github.com/cwj980119/Unity-Escape_T/tree/1012/Escape_T/Assets/Scrpits 에서 확인할 수 있다.

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

>## 참조
>- https://unitybeginner.tistory.com/
>- https://wergia.tistory.com/category/Unity3D
>- [유튜브 CodeMonkey](https://www.youtube.com/channel/UCFK6NCbuCIVzA6Yj1G_ZqCg)
>...
