<style type='text/css'>
    st1 {background-color: gold; color: white; font-weight:bold;}
    st2 {background-color: limegreen; color: white; font-weight:bold;}
    st3 {background-color: deepskyblue; color: white; font-weight:bold;}
    st4 {background-color: crimson; color: white; font-weight:bold;}
</style>  

# 프로젝트명 : 캠퍼스 서바이벌(개발자 : 연정환)

# 목차
> [1. 컨셉](#concept)  
> [2. 관련 이미지와 동영상](#reference)  
> [3. 대표 이미지](#main_img)  
> [4. 컨셉 & 대표이미지 기반 작품묘사](#description)  
> [5. 「캠퍼스 서바이벌」 구성 요소](#component)  
> [6. 게임 시스템 디자인](#sys_design)  
> [7. 개발 요구사항 & 흐름도](#requirements_flowchart)

# 1. 컨셉<a name = "concept"/>

## Main Concept : 대학 과정
> 대학교 생활(1~4학년)에서 겪는 여러 난관들을 처치하며 졸업을 목표로 게임을 진행.  
> 대학생활을 겪어본 유저들로부터 공감대를 형성시켜 게임의 몰입도 증가.

### Sub Concept-1 : 스트레스 해소
> 대학 생활에서 나오는 여러가지 스트레스 요인들을 부숴가며 스트레스 해소.

### Sub Concept-2 : 밈(공감대)
> 많은 대학생들이 공감할 만한 밈이나 상황들을 추려내서 공감대를 형성.

### Sub Concept-3 : 타격감
> 타격 이펙트, 사운드 에 중점을 두어 타격감이 넘치는 게임.

### Sub Concept-4 : 배재대학교
> 배재대학교 캠퍼스를 배경으로 제작. 배재대 학생들의 흥미를 유발.

### Sub Concept-5 : VR(Virtual Reality)
> VR기반으로 게임을 개발해서 색다른 경험 제공.
<br/>

# 2. 관련 이미지와 동영상<a name = "reference"/>
## 이미지
<p align="center">
 <img src="./img/KU.png" alt="KU_Metaverse"><br/>
 <em>건국대학교 메타버스</em>
</p>
 
## 동영상
<p align="center">
 <img src="./img/TitanSlayer.png" alt="TitanSlayer"/>
 <br/>
 <a href="https://www.youtube.com/watch?v=2u_eTJbBGb0" target="_blank">
  Titan Slayer(게임 플레이 방식)
 </a>
</p>

# 3. 대표 이미지<a name = "main_img"/>
<p align="center">
 <img src="./img/대표 이미지.png" alt="대표 이미지">
</p>

<br/><br/>

# 4. 작품묘사<a name = "description"/>

### 대표이미지 기반
 > 픽셀, 로우폴리 스타일로 오브젝트를 구성.
 > 배재대학교 캠퍼스 전경을 참고해서 맵 디자인.

### 컨셉 기반
 > 스테이지 구성을 **대학생활**에 맞추어 구성.   
 > 오브젝트가 플레이어를 향해 날아오면 그것을 **파괴**해나가면서 점수를 얻어나간다.  
 > 플레이어를 향해 날아오는 오브젝트들은 대학생활을 하면서 **공감갈 만한 내용**들로 구성.  
 > 플레이어가 오브젝트 파괴에 성공했을 시 **타격음과 이펙트**, 컨트롤러 진동으로 파괴했다는 정보를 확실히 전달.  
 > **Oculus Quest2**의 컨트롤러를 이용해서 게임을 진행.

# 5. 「캠퍼스 서바이벌」 구성 요소<a name = "component"/>

## 5-1. 메커니즘
[게임 방식]
> 1. VR게임으로 주어진 무기를 이용해 밀려오는 적(과제물)을 처치. 플레이어는 고정된 위치에서 플레이 한다.  
> 2. 무기는 스테이지 클리어(학년 진급) 시 스테이지에 해당하는 무기 지급. 첫 스테이지에는 한손검을 소지. 
> 3. 총은 트리거를 사용해 격발이 가능하고, 광선검은 트리거를 당긴채 휘두르면 넓은 범위의 검기를 발사. 방패는 날아오는 공격을 막아낼 수 있음.  
> 4. 무기는 메뉴키를 통해 교체가 가능하며, 교체 시 쿨타임 적용. 적의 특징에 따라 효과적인 무기가 있다. 이를 잘 캐치해서 진행하는 것이 중요.

 [도전 과제]
> 1. 총 4개의 스테이지로 구성(대학교 1학년 ~ 4학년) 각 스테이지 마다 일반적인 적(과제물)과 특수한 적(중간, 기말고사)로 구성.  
> 2. 체력을 유지한 채 스테이지 클리어 시 게임 성과에 따라 점수(성적) 책정.  
> 3. 체력을 전부 소진 시 스테이지 종료 및 게임 오버.
> 4. 최종 단계 클리어 시 졸업 축하 메세지와 함께 성적 표시.  
 
 [재미 요소]
> 1. 스테이지마다 나오는 적들을 각 학년마다 있을 법한 어려운 일들로 구성해 공감을 이끌어낸다.  
> 2. 난이도는 총 두가지(easy, hard)로 설정해 플레이어의 성향에 맞게 플레이 가능.
> 3. 2인 모드(깐부 모드(협동)/라이벌 모드(경쟁))를 구현해 친구와 같이 즐길 수 있음.

## 5-2. 이야기
[시놉시스]
```
"드디어 나의 캠퍼스 라이프가 시작되는구나!"
2022년 배재대학교에 신입생으로 입학하게된 배나섬 군(20, 남).
갓 성인이 된 나섬군은 큰 기대를 안고 대학 생활을 시작하게 된다.
앞으로 펼쳐질 그의 미래는...
```

[만들게 된 배경]  
> 대학 생활에서의 어려움은 많은 사람들의 공감을 얻어낼 수 있을거라 생각했고,  
> 본인도 직접 경험하고 있기에 이를 재미 요소로 승화시켰을 때 아이디어들을 많이 얻을 수 있을거라 생각했다.


## 5-3. 미적요소

[시각 효과]  
> 1. 배경 - 배재대 캠퍼스를 배경으로 구현해 배재대 학생들의 흥미를 유발.
> 2. 적 디자인 - 귀엽지만 악랄한 이미지의 적으로 구성해 적이라는 이미지를 확실하게 전달.
> 3. 컬러 - 파스텔톤으로 구성해 화사한 느낌으로 구성.

[음향 효과]  
> 1. 공격과 피격의 타격음을 확실하게 설정하여 타격감을 극대화.
> 2. 밈 요소의 더빙을 통해 또 다른 재미 추가.

## 5-4. 기술
> 1. Unity 기반 VR게임
> 2. Oculus Quest2 환경 개발
> 3. 최대 2인 멀티플레이 지원
 
# 6. 게임 시스템 디자인<a name = "sys_design"/>  
[게임 오브젝트]  

| 오브젝트 타입 | 오브젝트 이름                 | 비고                 |
| :-----------: | :-----------                  | :-----:              |
| weapon        | 한손검(sword)                 | <st1>stage 1</st1>   |
| weapon        | 총(gun)                       | <st2>stage 2</st2>   |
| weapon        | 방패(shield)                  | <st3>stage 3</st3>   |
| weapon        | 광선검(lightSaber)            | <st4>stage 4</st4>   |
| enemy         | 병아리(chick)                 | <st1>stage 1</st1>   |
| enemy         | 화난 병아리(angryChick)       | <st1>stage 1</st1>   |
| enemy         | 달걀(egg)                     | <st1>stage 1</st1>   |
| enemy         | 흰색 닭(chicken)              | <st1>stage 1</st1>   |
| enemy         | 검은색 닭(blackChicken)       | <st1>stage 1</st1>   |
| enemy         | 황금 닭(goldChicken)          | <st1>stage 1</st1>   |
| enemy         | 황금 깃털(goldFeather)        | <st1>stage 1</st1>   |
| enemy         | 악마(devil)                   | <st2>stage 2</st2>   |
| enemy         | 박쥐(bat)                     | <st2>stage 2</st2>   |
| enemy         | 대왕 박쥐(bigBat)             | <st2>stage 2</st2>   |
| enemy         | 전공 교수님(majorProfessor)   | <st2>stage 2</st2>   |

[플레이어 파라미터]  

| 파라미터              | 설명                                      |  비고         |
| :-----------          | :-----------                              | :------------ |
| helthPoint(체력)      | 플레이어의 체력 수치                      |               |
| weapon(무기)          | 플레이어가 들고 있는 무기                 |               |
| weaponBag(무기)       | 무기를 선택할 수 있는 선택창              |               |
| score(점수)           | 플레이어가 처치한 적에 따라 증가하는 점수 |               |

[enemy 파라미터]  

| 파라미터              | 설명                                      |  비고                                 |
| :-----------          | :-----------                              | :------------                         |
| grade(등급)           | enemy의 등급                              | normal, elite, boss로 구분            |
| point(포인트)         | enemy를 처치할 시 얻는 점수               | 등급에 따라 결정                      |

[플레이어 액션 리스트]  

| 액션                  | 설명                                                                                  |
| :-----------          | :-----------                                                                          |
| chooseWeapon          | weaponBag 활성화                                                                      |
| gutShooting           | 트리거를 당길시 총알이 나감                                                           |
| swordAuraCasting      | 트리거를 당기고 lightSaber를 휘두를시 전방으로 검기 방출                              |

[enemy 액션 리스트]  

| 액션                  | 설명                                                                                  |
| :-----------          | :-----------                                                                          |
| taggingEnemy          | enemyObj에 stage마다 설정 해준 이름을 붙혀줌                                          |
| respawnEnemy          | 랜덤한 위치에서 enemyObj 생성 후 플레이어를 향해 날아감                               |
| aliveEnemy            | EnemyObj가 살아남아 alive 구간에 도달한 경우 -> 플레이어의 helthPoint 감소            |
| attackPattern         | bossEnemy의 특수 공격 패턴 ex&#41;황금 닭의 황금 깃털 발사                            |

[게임규칙]
> 1. weapon과 enemy 충돌시 enemyObj는 소멸 score 증가  
> 2. enemy 등급에 따라 normal은 1번 elite는 2번 충돌시 소멸  
> 3. boss enemy는 특수 패턴을 파훼시 소멸  
> 4. enemy는 생성된 후 플레이어 뒤쪽에 alive구역을 향해 이동. 구역에 도달시 경고음과 함께 hp감소  
> 5. 스테이지 마지막 boss 패턴 파훼시 스테이지 클리어  
> 6. 스테이지 클리어 시 player score에 따라 등급 산출  
> 7. 스테이지 4 클리어시 전체 스테이지 평균 등급 산출  
> 8. 각 스테이지 마다 f등급이 나올 경우 스테이지 1부터 다시 실행  

# 7. 개발 요구사항 & 흐름도<a name="requirements_flowchart"/>

## 요구사항

### 플레이어 파라미터
<blockquote>
    <ol>
        <li>구성 : WeaponBag(무기 관리 오브젝트), HP, Score</li>
        <li>HP최대치는 100으로 설정</li>
        <li>HP가 20이하로 내려갈 시 경고음과 강한 컨트롤러 진동으로 알림 표시</li>
        <li>enemy처치시 score상승 점수 시스템은 Enemy 속성 참고</li>
    </ol>
</blockquote>

### 오브젝트 속성 - WeaponBag
<blockquote>
    <ol>
        <li>구성 : Sword, Gun, Shield, LightSaber, WeaponBagUI</li>
        <li>WeaponBagUI - 무기 교체를 담당하는 UI, 컨트롤러 상단 버튼 클릭 시 컨트롤러 상단에 뜨게 설정</li>
        <li>WeaponBagUI - 스틱을 이용해서 조작, 스틱을 좌우로 움직여 weapon을 선택하고 스틱을 앞으로 누르면 선택한 weopon으로 갈아껴지고, UI는 사라짐</li>
        <li>Sword - <st1>stage 1</st1>에서 주어지는 기본 무기</li>
        <li>Gun - <st2>stage 2</st2>에서 주어지는 무기. 정면 트리거를 누르면 총알을 발사. 측면 트리거를 누르면 장전. 총알에만 충돌 적용</li>
        <li>Shield - <st3>stage 3</st3>에서 주어지는 무기. Enemy와 충돌 처리 없음. 보스의 특정 기믹 처리 시 사용</li>
        <li>LightSaber - <st4>stage 4</st4>에서 주어지는 무기. 정면 트리거를 1초동안 누르면 swordAura 캐스팅완료. 그 후 휘두를 방향으로 발사</li>
    </ol>
</blockquote>

### 오브젝트 속성 - Enemy
<blockquote>
    <ol>
        <li>등급 구성 : Normal, Elite, Boss</li>
        <li>게임 시작시 플레이어로부터 10m가량 떨어진 EnemySpawnZone에서 플레이어를 향해 달려오는 Enemy 생성</li>
        <li>EnemySpawnZone은 사다리꼴 모양의 3면으로 구성을해서 플레이어를 중심으로 모이게 설정</li>
        <li>생성되는 Enemy의 등급은 Normal, Elite로 8:2비율로 생성</li>
        <li>플레이어 시야 방향 뒤쪽에 AliveZone 도달 시 플레이어 에게 Normal은 1 Elite는 3의 데미지를 입힘</li>
        <li>데미지를 줄 때 마다 경고음과 약한 컨트롤러 진동으로 상태 전달</li>
        <li>각 stage마다 다른 Boss Enemy 배치, 각 보스들은 고유의 패턴 존재</li>
        <li>보스들의 패턴은 스테이지 항목 참조</li>
        <li><i>(TODO:점수 계산 공식 추가 필요)</i></li>
    </ol>
</blockquote>

### 스테이지 공통
<blockquote>
    <ol>
        <li>시작 시 sword를 장착하고 시작</li>
        <li>스테이지의 구성은 1분(Normal,Eliete 구간) + 30초~1분(Boss 구간)를 한 step으로 묶어 4번 반복. 약 6~8분 정도의 길이</li>
        <li><i>(TODO:스테이지 UI 구성 추가 필요)</i></li>
    </ol>
</blockquote>

### <st1>스테이지 1</st1>
<blockquote>
    <ol>
        <li>기본 Enemy는 병아리, 보스 Enemy는 닭</li>
        <li>normal 등급의 병아리는 노란색, Elite등급의 병아리는 빨간색으로 설정</li>
        <li>Boss 색상 : step1 - 흰색, step2 - 검은색, step3 - 흰색&검은색 닭 동시 출현, step4 - 황금색</li>
        <li>Boss 공통 패턴 1 : 플레이어에게 달걀을 4번 연속던짐. 무기로 파괴 가능하며 파괴를 못할 시 1의 데미지</li>
        <li>Boss 공통 패턴 2-1 : 플레이어가 달걀을 일정 이상 처치 시 다가와서 플레이어 쪼기. 넉백 실패 시 4의 데미지. 플레이어 HP가 전부 소진 될 때 까지 반복</li>
        <li>Boss 공통 패턴 2-2 : 쪼기 모션 시전 도중 부리에 충돌처리. 부리 공격에 성공하면 넉백 모션을 실행. 총 4번의 넉백이후 1, 2 stage 도망, 3, 4스테이지 사망</li>
        <li>Boss 패턴 step1, 2 : 달걀 던지기 패턴 이후 EnemySpawnZone을 기준으로 위치 이동.</li>
        <li>Boss 패턴 step3    : 왼쪽과 오른쪽에 step1, step2 보스를 각각 배치</li>
        <li>Boss 패턴 step3    : 모든 패턴은 두 보스가 중복해서 사용하지 않게 설정</li>
        <li>Boss 패턴 step4    : 달걀 던지기 패턴 이후 쪼기 패턴 전에 공중으로 날아올라서 깃털 날리기 패턴 시전. 깃털의 데미지는 1</li>
        <li>Boss 패턴 step4    : 한번에 5개의 깃털을 여러 방향으로 발사 달걀과 동일하게 처리 가능. 총 5번 공격 이후 쪼기 공격 실행</li>
    </ol>
</blockquote>

### <st2>스테이지 2</st2>
<blockquote>
    <ol>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
    </ol>
</blockquote>

### <st3>스테이지 3</st3>
<blockquote>
    <ol>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
    </ol>
</blockquote>

### <st4>스테이지 4</st4>
<blockquote>
    <ol>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
    </ol>
</blockquote>

### 시작 화면 & UI
<blockquote>
    <ol>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
        <li></li>
    </ol>
</blockquote>

<hr/>

## 6주 요구사항

### 1주차(PlayerWeapon 구현)
> 9. ~~(PlayerWeapon)게임 시작히 플레이어는 기본적으로 양손에 sword weaponObj를 장착하고 시작~~  
> 11. ~~(PlayerWeapon)sword는 검의 몸체 부분이 enemy와 충돌만 있어도 상호작용~~  
> 12. ~~(PlayerWeapon)gun은 컨트롤러의 트리거부분 누를 시 단발 발사~~ (coroutine 사용 쿨타임 적용)  
> 13. (PlayerWeapon)lightSaber는 컨트롤러의 트리거를 누른 상태(1초간)에서 검을 휘두를시 검을 휘두른 방향으로 swordAura 발사  

### 2주차(WeaponBag & Parameter & EnemyBase 구현)
> 10. (PlayerWeapon)각 컨트롤러의 상단부 버튼(Left : Y, Right : B)클릭 시 클릭한 컨트롤러 방향에 weaponBag 활성화  
> 14. (PlayerParameter)최대 helthPoint는 100으로 설정, 플레이어에게 체력 게이지는 보여주지않고 체력이 20이하로 내려갈 시 경고음과 함께 빨간색 화면이 깜빡임을 통해 경고표시  
> 15. (EnemyBase)enemy는 enemySpawnArea(player로 시점방향으로 10m 떨어진 곳)에서 랜덤하게 생성 후 palyer를 향해 다가옴  
> 16. (EnemyBase)랜덤하게 생성되는 enemy에 normal, elite등급을 설정하고, 8:2 비율로 생성  
> 17. (EnemyBase)enemyAilveArea(player 시점방향 뒤쪽으로 2m떨어진 곳)에 enemyObj도달 시 player healthPoint감소  
> 18. (EnemyBase)normal은 2, elite는 5만큼의 데미지를 줌  

### 3주차(Enemy 애니메이션)
> 19. (<st1>stage 1</st1>)병아리는 normal 등급, 화난 병아리는 elite등급  
> 20. (<st1>stage 1</st1>)총 4번(1학기 중간, 기말, 2학기 중간, 기말고사) boss등급 enemy출현  
> 21. (<st1>stage 1</st1>)1학기 중간고사 - 흰색 닭  
> 28. (<st1>stage 1</st1>)1학기 기말고사 - 검은색 닭  
> 34. (<st1>stage 1</st1>)2학기 기말고사 - 황금 닭  

### 4주차(AttackPattern - 1)
> 22. (<st1>stage 1</st1>)흰색 닭 attack pattern - enemySpawnArea에서 player를 향해 달걀 3번 투척 후 오른쪽 or 왼쪽 이동 후 반복. enemySpawnArea를 3등분한 기준으로 이동.  
> 23. (<st1>stage 1</st1>)흰색 닭 attack pattern - 중앙에서 달걀 5개를 동시에 투척(수평방향)  
> 24. (<st1>stage 1</st1>)흰색 닭 attack pattern - 21)패턴은 3번 연속 실행 후 2초간 딜레이. 총 3번의 반복동작 이후 22)패턴 실행  
> 25. (<st1>stage 1</st1>)흰색 닭 attack pattern - 달걀의 데미지는 normal등급 enemy와 동일 

### 5주차(AttackPattern - 2)
> 26. (<st1>stage 1</st1>)흰색 닭 attack pattern - 달걀 50개 파괴시 19)패턴의 반복 동작 이후 플레이어를 향해 날아들어 쪼기 패턴 실행  
> 27. (<st1>stage 1</st1>)흰색 닭 attack pattern - 쪼기 데미지는 3 쪼는 순간에만 오브젝트가 활성화되고, 활성화 될 때 공격시 강하게 넉백. 총 3번의 넉백 성공시 도주  
> 28. (<st1>stage 1</st1>)검은색 닭 attack pattern - 19), 20)패턴과 동일 쪼기 패턴의 데미지만 4로 변경  
> 35. (<st1>stage 1</st1>)황금 닭 attack pattern - 19), 20)패턴과 동일  

### 6주차(AttackPattern - 3)
> 31. (<st1>stage 1</st1>)흰색 닭&검은색 닭 attack pattern - 달걀 3번 투척 후 이동 패턴을 총 4구역으로 나눠서 player시야 기준 왼쪽 2구역에 흰색 닭, 오른쪽 2구역에 검은색 닭 배치. 패턴은 순차적 실행(동시x)  
> 32. (<st1>stage 1</st1>)흰색 닭&검은색 닭 attack pattern - 쪼기 패턴도 동시 실행. 흰색>검은색 순으로 실행  
> 33. (<st1>stage 1</st1>)흰색 닭&검은색 닭 attack pattern - 쪼기 패턴을 진입하는 달걀파괴 횟수 60회로 증가, 넉백 성공은 각각 2번씩 성공시 도주  
> 36. (<st1>stage 1</st1>)황금 닭 attack pattern - 달걀을 20, 40, 60개 파괴시 19)패턴 반복동작 이후 중앙으로 이동 후 공중에서 플레이어를 향해 깃털을 다수 발사. 깃털의 데미지는 1  
> 37. (<st1>stage 1</st1>)황금 닭 attack pattern - 35)패턴 총 3번 실행 후 쪼기 패턴 실행. 5번 넉백시 도주 후 스테이지 클리어  