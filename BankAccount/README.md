# 은행 계좌

은행 계좌를 나타내는 `BankAccount` 클래스를 구현하시오.

### 요구사항

**BankAccount 클래스:**

- **필드/속성**:
  - `AccountNumber`: 계좌번호 (읽기 전용 속성)
  - `OwnerName`: 예금주 이름 (읽기 전용 속성)
  - `Balance`: 현재 잔액 (읽기 전용 속성)

- **생성자**:
  - 계좌번호와 예금주 이름을 받아 초기화
  - 초기 잔액은 0원

- **메서드**:
  - `Deposit(int amount)`: 입금. 양수만 입금 가능
  - `Withdraw(int amount)`: 출금. 양수만 출금 가능, 잔액보다 큰 금액은 출금 불가
  - `ShowInfo()`: 계좌 정보 출력

**동작 조건:**

- 입금 시 0 이하의 금액은 무시하고 "입금 금액은 0보다 커야 합니다." 출력
- 출금 시 잔액 부족하면 "잔액이 부족합니다." 출력
- 정상 입금/출금 시 "입금/출금 완료" 메시지와 잔액 출력

### 테스트 코드

```csharp
BankAccount account = new BankAccount("123-456-789", "홍길동");
account.ShowInfo();

account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);

account.ShowInfo();
```

## 예상 실행 결과

```
[계좌 정보] 123-456-789 (홍길동) - 잔액: 0원
50000원 입금 완료. 잔액: 50000원
30000원 입금 완료. 잔액: 80000원
20000원 출금 완료. 잔액: 60000원
잔액이 부족합니다.
입금 금액은 0보다 커야 합니다.
[계좌 정보] 123-456-789 (홍길동) - 잔액: 60000원
```
