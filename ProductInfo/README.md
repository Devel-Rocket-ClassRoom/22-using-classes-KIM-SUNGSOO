# 상품 정보

상품의 가격과 할인 정보를 관리하는 `ProductInfo` 클래스를 구현하시오.

### 요구사항

**ProductInfo 클래스:**

- **속성**:
  - `Name`: 상품명 (읽기/쓰기 가능)
  - `Price`: 원래 가격 (읽기/쓰기 가능)
  - `DiscountPercent`: 할인율 (읽기/쓰기 가능, 0~100)
  - `DiscountAmount`: 할인 금액 (읽기 전용, 계산된 속성)
  - `FinalPrice`: 최종 가격 (읽기 전용, 계산된 속성)

- **생성자**:
  - 상품명과 가격만 받는 생성자: 할인율은 0으로 초기화
  - 상품명, 가격, 할인율을 모두 받는 생성자

- **메서드**:
  - `PrintInfo()`: 상품 정보 출력

### 테스트 코드

```csharp
ProductInfo product1 = new ProductInfo("노트북", 1500000);
product1.PrintInfo();

ProductInfo product2 = new ProductInfo("키보드", 80000, 20);
product2.PrintInfo();

product2.DiscountPercent = 30;
product2.PrintInfo();
```

## 예상 실행 결과

```
[상품 정보] 노트북 - 가격: 1500000원, 할인: 0% (-0원), 최종가: 1500000원
[상품 정보] 키보드 - 가격: 80000원, 할인: 20% (-16000원), 최종가: 64000원
[상품 정보] 키보드 - 가격: 80000원, 할인: 30% (-24000원), 최종가: 56000원
```
