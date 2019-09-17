### 需求

在不同 form 之間的欄位，要可以同步修改後的內容

### 想法

- 每個欄位對應至一個 interface 及 PubSubStoreField 項目
- 當某個 Form 需要實作同步功能，就實作該欄位 interface

### 可改進之處

- PubSubStore 用了相當多的 dynamic，但目前想不到更好的方式
- 還不算是 Publish/Subscribe Pattern 的實作  