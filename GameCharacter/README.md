# 게임 캐릭터

게임 캐릭터를 나타내는 `GameCharacter` 클래스를 구현하시오.

### 요구사항

**GameCharacter 클래스:**

- **속성**:
  - `Name`: 캐릭터 이름 (읽기 전용)
  - `Level`: 레벨 (읽기 전용)
  - `MaxHp`: 최대 체력 (읽기 전용, 레벨 x 100)
  - `CurrentHp`: 현재 체력 (읽기 전용)
  - `AttackPower`: 공격력 (읽기 전용, 레벨 x 10)
  - `IsAlive`: 생존 여부 (읽기 전용, CurrentHp > 0)

- **생성자**:
  - 이름과 레벨을 받는 생성자
  - 생성 시 CurrentHp는 MaxHp와 동일하게 설정

- **메서드**:
  - `Attack(GameCharacter target)`: 대상에게 공격력만큼 데미지를 입힘
  - `TakeDamage(int damage)`: 데미지를 받아 CurrentHp 감소. 0 이하로 떨어지지 않음
  - `ShowStatus()`: 캐릭터 상태 출력

### 테스트 코드

```csharp
GameCharacter hero = new GameCharacter("용사", 5);
GameCharacter monster = new GameCharacter("고블린", 3);

hero.ShowStatus();
monster.ShowStatus();

Console.WriteLine("\n=== 전투 시작 ===");

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();

hero.Attack(monster);
monster.ShowStatus();
```

## 예상 실행 결과

```text
[용사] Lv.5 - HP: 500/500, 공격력: 50
[고블린] Lv.3 - HP: 300/300, 공격력: 30

=== 전투 시작 ===
용사이(가) 고블린에게 50 데미지를 입혔습니다!
[고블린] Lv.3 - HP: 250/300, 공격력: 30
용사이(가) 고블린에게 50 데미지를 입혔습니다!
[고블린] Lv.3 - HP: 200/300, 공격력: 30
용사이(가) 고블린에게 50 데미지를 입혔습니다!
[고블린] Lv.3 - HP: 150/300, 공격력: 30
용사이(가) 고블린에게 50 데미지를 입혔습니다!
[고블린] Lv.3 - HP: 100/300, 공격력: 30
```
