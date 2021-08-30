# ETS2Discord
## 概要
ETS2からETS2 TelemetryServerを使用してデータを取得し、Discordに情報を表示するツールです。

ツール名:ETS2DiscordRichPresence.exe

制作者:焼きすぎた鮭 Twitter:@\_yakisugita_

## 利用に関して
ツールの使用は自己責任でお願いします。

二次配布・改変やその配布はOKです。ただし自作発言はNG

## 開発環境
- Windows 10 Home 21H1
- Visual Studio 2019

## 動作環境
.NET Framework 4.7.2で動作します。

ETS2TelemetryServerはv4.0およびv4.1.2.3で動作を確認しています。

## 使い方
### 更新に関して
設定ファイル(ets2discord.ini)は前のバージョンのものをそのまま使えます。

### 導入
ツールのzipファイルをダウンロード・解凍

https://yakijake.net/versions/ETS2DRP/

まずETS2DRP_initial.exeを起動してください

画面の指示に従ってETS2TelemetryServerの導入・初期設定をし、それが終わったら本体を起動してください。

ETS2をプレイしてみて、実際に表示されるか試してみて下さい。
※セーブデータを読み込んで、トラックに乗る(道路などが読み込まれる)まではDiscordに表示されません

## TruckersMPの表示について
Trucky APIを使用して情報を取得しています。
TruckersMPのゲーム内設定で、「general」タブの「Discord Rich Presence」のチェックを外すと、このツールのものが表示されるようになります。

## 更新履歴
 - 2021/08/30 v1.2.1
     - カスタムテキストの不具合修正,エラーログ
 - 2021/08/27 v1.2
     - カスタムテキスト機能,右クリメニューから表示,ETS2TSv4.1.2.3へ対応
 - 2021/08/11 v1.1.1
     - 「このツールについて」を追加,StatusCodeのチェック
 - 2021/08/05 v1.1
     - 更新機能強化,ATSへの対応,Discordにアイコン表示,著作権表示,TruckersMPのサーバー・ID等の表示
 - 2021/07/31 v1.0.1
     - 誤字修正,プレイ時間表示,新バージョン通知の改修,アイコン変更
 - 2021/07/25 v1.0
     - 公開
