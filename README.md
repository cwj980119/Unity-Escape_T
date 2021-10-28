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

	  - 코드를 활용한 동작
	  - Unity Tool을 활용한 동작

> 5. 마무리


> ## 1. 개요
>-  Escape-T 게임은 어드벤처 게임과 퍼즐 게임의 일종인 방탈출 게임이다.
>- 방탈출 게임에 대한 자세한 설명은 [여기](https://namu.wiki/w/방탈출) 참조 하기 바란다.
>- Escape-T는 4개의 층에 다양한 퀴즈와 단서를 활용하여 각 층을 탈출하여 최종 목표까지 가는 게임이다. 
>- Escape-T는 Unity엔진(2020.3.12버전)으로 개발되었다. 
>- 스크립트 언어는 C#으로 개발됬다.

> ## 2. 스토리
> 졸업프로젝트 전날, 4학년 홍와우(캐릭터 이름)는 8층에서 작업을 하려고 방에 들어가서 그 컴퓨터 USB를 꽂고 확인해볼려는 순간, 천둥번개 소리에 그대로 기절을 해버리고...
> 그런데, 일어나보니 4층 열람실이였고, 졸업작품이 담겨있는 8층으로 가야하는데 과연 홍와우는 무사히 8층까지 가서 USB를 찾아서 무사히 졸업작품을 발표하여 졸업할 수 있을까?
> 그건 여러분의 플레이에 달려있다.

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
	- ① 인벤토리 : 인벤토리 창을 열 수 있다.(인벤토리 항목 참고)
	- ② 설정 : 설정창을 열 수 있다. (설정 항목 참고)
	- ③ 조이스틱 : 게임 캐릭터를 움직일 수 있다.
	- ④ 상호작용버튼 : 게임 중 문을 열거나 물건을 주울 수 있다.
	- ⑤ 캐릭터(홍와우): 게임을 진행하는 캐릭터이다.
	- ⑥ 물건 : 게임을 푸는 단서이다. ④을 통해 수집할 수 있다.
```

>#### - 인벤토리
>- 인벤토리 창은 다음과 같이 생겼다.
>
>![Inventory](https://user-images.githubusercontent.com/80233719/139191800-7173994e-c954-4494-9538-a727ab57a4cf.jpg)
>```
> 	- 1번 버튼을 눌러 켤 수 있다.
> 	- 물건 근처에서 4번 버튼을 누르면 여기에 저장이 된다.
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
>	i. 맨 처음 제4공학관 앞에서 시작한다.
![tutorial1](https://user-images.githubusercontent.com/80233719/139273323-0da7514d-a000-4f73-8e31-72af8f8b8035.jpg)
>	ii. 8층으로 이동하여 졸업작품을 확인하기 위해 컴퓨터를 켠다.
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
>	- 8층까지 올라가서 다시 USB를 가져오고 무사히 졸업작품을 발표하게 된다.
>![tutorial2](https://user-images.githubusercontent.com/80233719/139273831-ddea9c71-8903-43f9-938b-d96d4071dfdc.jpg)
