# ETS2Discord
## 概要
ETS2からETS2 TelemetryServerを使用してデータを取得し、Discordに情報を表示するツールです。

ツール名:ETS2DiscordRichPresence.exe

制作者:焼きすぎた鮭 Twitter:@\_yakisugita_

## 利用に関して
ツールの使用は自己責任でお願いします。

二次配布・改変やその配布はOKです。

## 動作環境
.NET Framework 4.7.2で動作します。

## 使い方
### 導入
ETS2 TelemetryServerをダウンロード ※ETS2 64bitのみ対応

https://github.com/mike-koch/ets2-telemetry-server

「Code」ボタン->「Download ZIP」

解凍して、serverフォルダのEts2Telemetry.exeを起動

右下の「install」をクリックしてインストール

「Telemetry API URL」をコピーかメモしておく

本ツールのzipファイルをダウンロード・解凍

https://drive.google.com/file/d/1qrlyIlAWkCERWd41EK31ptJ_8K-BSlzj/view?usp=sharing

exeファイルを起動させたら「設定」で設定ウィンドウを開き、「その他の設定」 Telemetry API URLにメモったURLを貼り付けか入力

※ウィンドウが表示されない場合はタスクバーの「ETS2」のアイコンをダブルクリック

設定ウィンドウの「OK」ボタンを押して、タスクバーのアイコンを右クリックして終了させてまた起動


ETS2をプレイしてみて、実際に表示されるか試してみて下さい。
※セーブデータを読み込んで、トラックに乗る(道路などが読み込まれる)まではDiscordに表示されません

## 更新履歴
2021/07/31
v1.0.1 誤字修正,プレイ時間表示,新バージョン通知の改修,アイコン変更

2021/07/25
公開
