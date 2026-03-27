# 📝 ASP.NET Core MVC + Vue 3 (ESM Mode) Todo List

這是一個練習專案，在 ASP.NET Core 環境中實現 Vue 3 的開發。

## 📅 明日待辦清單 (To-Do for Tomorrow)

### 第一階段：前端互動功能
- [ ] 實作 `v-model` 與 `v-for` 渲染。

### 第二階段：後端整合
- [ ] 使用 `fetch` 或 `axios` 將資料持久化至 C# 後端。
- [x] 實作讀取/存入本地資料庫 (SQL Server / SQLite)。

### 第三階段：自動化流程 (CI/CD)
[ ] 持續整合 (CI)：建立 GitHub Actions 流程，每次 Push 自動執行 dotnet build。

[ ] 持續部署 (CD)：配置 PowerShell 腳本，當測試通過後，自動將編譯後的檔案發布（Publish）至資料夾或伺服器。