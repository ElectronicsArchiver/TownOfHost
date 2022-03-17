# Town Of Host
[![TownOfHost-Title](./Images/TownOfHost-Title.png)](https://youtu.be/IGguGyq_F-c)

## このModについて
このModは非公式のものであり、このModの開発に関してAmong Usの開発元である"Innersloth"は一切関与していません。<br>
このModの問題などに関して公式に問い合わせないでください。<br>

[![Discord](./Images/TownOfHost-Discord.png)](https://discord.gg/v8SFfdebpz)

## 特徴
このModはホストのクライアントに導入するだけで動作し、他のクライアントのModの導入/未導入及び端末の種類に関係なく動作します。<br>
また、カスタムサーバーを利用したModと違い、URLやファイル編集などによるサーバー追加も不要なため、ホスト以外のプレイヤーはTown Of Hostを導入したホストの部屋に参加するだけで追加役職を楽しむことができます。<br>

しかし、以下の制限が発生することにご注意ください。<br>

- ホストが途中抜けをするなどの要因でホストが変更された場合、追加役職に関する処理が正常に動作しない可能性がある。
- 特殊役職を使用した場合、その特殊役職の設定を書き換える。(例 : 通気口のクールダウンをなくすなど)

なお、ホスト以外のプレイヤーがこのModを導入した状態でプレイすると、以下のような変更が行われます。<br>

- 特殊役職独自の開始画面の表示
- 特殊役職の正常な勝利画面の表示
- 設定項目の追加
- その他

## Modの設定変更画面
待機ロビーでTabキーを押すと、部屋設定のテキストがTown Of Host専用の設定画面に変化します。<br>
操作方法は以下の通りです。<br>

| キー | 動作 |
| :---: | ---- |
| Tab | Modの設定画面の表示/非表示 |
| 十字キー上 | カーソルを上に移動 |
| 十字キー下 | カーソルを下に移動 |
| 十字キー右 | 選択中の項目を実行 |
| 十字キー左 | 一つ戻る |
| 数字キー | 数値を入力 |

## 役職

| インポスター陣営 | クルーメイト陣営 | 第三陣営 |
|----------|-------------|-----------------|
| [BountyHunter/バウンティハンター](###BountyHunter/バウンティハンター) | [Bait/ベイト](###Bait/ベイト) | [Jester/ジェスター](###Jester/ジェスター) |
| [SerialKiller/シリアルキラー](###SerialKiller/シリアルキラー) | [Mayor/メイヤー](###Mayor/メイヤー) | [Opportunist/オポチュニスト](###Opportunist/オポチュニスト) |
| [ShapeMaster/シェイプマスター](###ShapeMaster/シェイプマスター) | [SabotageMaster/サボタージュマスター](###SabotageMaster/サボタージュマスター) | [Terrorist/テロリスト](###Terrorist/テロリスト) |
| [Vampire/ヴァンパイア](###Vampire/ヴァンパイア) | [Sheriff/シェリフ](###Sheriff/シェリフ) |  |
| [Warlock/ウォーロック](###Warlock/ウォーロック) | [Snitch/スニッチ](###Snitch/スニッチ) |  |
| [Witch/魔女](###Witch/魔女) |  |  |
| [Mafia/マフィア](###Mafia/マフィア) |  |  |
| [Madmate/マッドメイト](###Madmate/マッドメイト) |  |  |
| [MadGuardian/マッドガーディアン](###MadGuardian/マッドガーディアン) |  |  |
| [MadSnitch/マッドスニッチ](###MadSnitch/マッドスニッチ) |  |  |

### BountyHunter/バウンティハンター

陣営 : インポスター<br>
判定 : インポスター<br>

表示されたターゲットをキルした場合、次のキルクールがとても短くなります。<br>
ターゲットではないプレイヤーをキルした場合は、キルクールが伸びてしまいます。<br>
また、設定でキルクールを2.5秒に設定する必要があります。<br>
ターゲットは一定時間ごとに変更されます。<br>

#### 設定

| 設定名 |
|----------|
| バウンティハンターのターゲットが変わる時間(s) |
| バウンティハンターがターゲットをキルした後のクールダウン(s) |
| バウンティハンターがターゲット以外をキルした時のクールダウン(s) |
| バウンティハンター以外のキルクールダウン(s) |

### SerialKiller/シリアルキラー

陣営 : インポスター<br>
判定 : シェイプシフター<br>

キルクールが短いインポスターです。<br>
その代わり、時間が来るまでにキルをしないと自爆してしまいます。<br>

#### 設定

| 設定名 |
|----------|
| シリアルキラーのキルクール(s) |
| シリアルキラーが自爆する時間(s) |

### ShapeMaster/シェイプマスター

陣営 : インポスター<br>
判定 : シェイプシフター<br>

シェイプマスターは変身後のクールダウンを無視し、再度変身することができます。<br>
通常では10秒しか変身できませんが、設定によって変身継続時間を変更することができます。<br>

| 設定名 |
|----------|
| シェイプマスターの変身可能時間(s) |

### Vampire/ヴァンパイア

陣営 : インポスター<br>
判定 : インポスター<br>

キルボタンを押してから一定時間経って実際にキルが発生する役職です。<br>
キルをしたときのテレポートは発生しません。<br>
また、キルボタンを押してから設定された時間が経つまでに会議が始まるとその瞬間にキルが発生します。<br>
しかし、[ベイト](###Bait/ベイト)をキルした場合のみ通常のキルとなり、強制的に通報させられます。<br>

#### 設定

| 設定名 |
|----------|
| ヴァンパイアのキルまでの時間(s) |

### Warlock/ウォーロック

陣営 : インポスター<br>
判定 : シェイプシフター<br>

ウォーロックが変身する前にキルすると相手に呪いがかかります。<br>
そして次変身すると、呪った人に一番近い人が死にます。<br>
呪いがかかった人は次の会議でマークがつき、会議後に死にます。<br>

### Witch/魔女

陣営 : インポスター<br>
判定 : インポスター<br>

キルボタンを押すとキルモードとスペルモードが入れ替わり、スペルモードの時にキルボタンを押すとその対象に魔術をかけることができる役職です <br>
魔術をかけられたプレイヤーには会議で特殊なマークが付き、その会議中が終わると死亡してしまいます。<br>

### Mafia/マフィア

陣営 : インポスター<br>
判定 : シェイプシフター<br>

初期状態で通気口やサボタージュ、変身は可能ですが、キルをすることはできません。<br>
マフィアではないインポスターが全員死亡すると、マフィアもキルすることができるようになります。<br>
キルができない状態でもキルボタンはありますが、キルをすることはできません。<br>
キルが可能になった後でも変身は継続して行うことができます。<br>

### Mare/メアー

陣営 : インポスター<br>
判定 : インポスター<br>

停電の時以外にキルをすることができません。<br>
しかし、キルが成功するとキルクールが半分になります。<br>

### Madmate/マッドメイト

陣営 : インポスター<br>
判定 : エンジニア<br>

インポスター陣営に属しますが、マッドメイトからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドメイトが誰なのかはわかりません。<br>
キルやサボタージュはできませんが、通気口に入ることができます。<br>

#### 設定

| 設定名 |
|----------|
| マッドメイト([マッドガーディアン](###MadGuardian/マッドガーディアン))が停電を直すことができる |

### MadGuardian/マッドガーディアン

陣営 : インポスター<br>
判定 : クルーメイト<br>

インポスター陣営に属しますが、マッドガーディアンからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドガーディアンが誰なのかはわかりません。<br>
しかし、自身のタスクを全て完了させるとキルされなくなります。<br>
キルやサボタージュはできず、通気口に入ることもできません。<br>

#### 設定

| 設定名 |
|----------|
| [マッドメイト](###Madmate/マッドメイト)(マッドガーディアン)が停電を直すことができる |
| マッドガーディアンが自身の割れたバリアを見ることができる |

### MadSnitch/マッドスニッチ

陣営 : インポスター<br>
判定 : クルーメイト<br>

インポスター陣営に属しますが、マッドスニッチからはインポスターが誰なのかはわかりません。<br>
インポスターからもマッドスニッチが誰なのかはわかりません。<br>
しかし、自身のタスクを一定数完了させるとインポスターの名前が赤色に変化します。<br>
ベントに入れることができません。<br>

#### 設定

| 設定名 |
|----------|
| [マッドメイト](###Madmate/マッドメイト)(マッドスニッチ)が停電を直すことができる |
| マッドスニッチのタスク数 |

### Bait/ベイト

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

キルされたときに、自分をキルしたプレイヤーに強制的に自分の死体を通報させることができる役職です。<br>

### Lighter/ライター

陣営 ：クルーメイト<br>
判定 ：クルーメイト<br>

タスクを完了させると、自分の視界が広がり、停電の視界減少の影響を受けなくなる。<br>

### Mayor/メイヤー

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

メイヤーは票を複数持っており、まとめて一人のプレイヤーまたはスキップに入れることができます。<br>

#### 設定

| 設定名 |
|----------|
| メイヤーの追加投票数 |

### SabotageMaster/サボタージュマスター

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

サボタージュマスターはサボタージュを早く直すことができます。
原子炉メルトダウンや酸素妨害、MIRA HQの通信妨害は片方を修理すれば両方が直ります。<br>
停電は1箇所のレバーに触れると全て直ります。<br>
PolusやThe Airshipのドアを開けるとその部屋の全てのドアが開きます。<br>

#### 設定

| 設定名 |
|----------|
| サボタージュマスターがサボタージュに対して能力を使用できる回数(ドア閉鎖は除く) |
| サボタージュマスターが1度に複数のドアを開けることを許可する |
| サボタージュマスターが原子炉メルトダウンに対して能力を使える |
| サボタージュマスターが酸素妨害に対して能力を使える |
| サボタージュマスターがMIRA HQの通信妨害に対して能力を使える |
| サボタージュマスターが停電に対して能力を使える |

### Sheriff/シェリフ

陣営 : クルーメイト<br>
判定 : インポスター(ホストのみクルーメイト)<br>

シェリフは人外をキルすることができます。<br>
しかし、クルーメイトをキルした場合、自分が死亡してしまいます。<br>
タスクはありません。<br>

#### 設定

| 設定名 |
|----------|
| シェリフが[ジェスター](###Jester/ジェスター)をキルできる |
| シェリフが[テロリスト](###Terrorist/テロリスト)をキルできる |
| シェリフが[オポチュニスト](###Opportunist/オポチュニスト)をキルできる |

### Snitch/スニッチ

陣営 : クルーメイト<br>
判定 : クルーメイト<br>

スニッチはタスクを完了させると人外の名前が赤色に変化します。<br>
しかし、スニッチのタスクが少なくなると人外に通知されます。

### Jester/ジェスター

陣営 : 第三<br>
判定 : クルーメイト<br>
勝利条件 : 投票で追放されること。<br>

投票で追放されたときに単独勝利となる第三陣営の役職です。<br>
追放されずにゲームが終了するか、キルされると敗北となります。<br>

### Opportunist/オポチュニスト

陣営 : 第三<br>
判定 : クルーメイト<br>
勝利条件 : いずれかの陣営が勝利したときに生き残っていること。<br>

ゲーム終了時に生き残っていれば追加勝利となる第三陣営の役職です。<br>
タスクはありません。<br>

### Terrorist/テロリスト

陣営 : 第三<br>
判定 : エンジニア<br>
勝利条件 : 全てのタスクを完了させた状態で死亡すること。<br>

自身のタスクを全て完了させた状態で死亡したときに単独勝利となる第三陣営の役職です。<br>
タスクを完了させずに死亡したり、死亡しないまま試合が終了すると敗北となります。<br>

## モード

### DisableTasks/タスクを無効化する

特定のタスクを無効化することができます。<br>

| 設定名 |
|----------|
| 原子炉起動タスクを無効化する |
| 医務室のスキャンタスクを無効化する |
| カードタスクを無効化する |
| 金庫タスクを無効化する |
| ダウンロードタスクを無効化する |

### HideAndSeek/鬼ごっこモード

#### クルーメイト陣営(青色)勝利条件
全てのタスクを完了させること。<br>
※幽霊のタスクはカウントされません。<br>

#### インポスター陣営(赤色)勝利条件
全てのクルーメイトをキルすること。<br>
※クルーメイトとインポスターが同数であってもクルーメイトが全滅していないと試合は終わりません。<br>

#### 狐(紫色)勝利条件
トロールを除くいずれかの陣営が勝利したときに生き残っていること。<br>

#### トロール(緑色)勝利条件
インポスターにキルされること。<br>

#### 禁止事項
・サボタージュ<br>
・アドミン<br>
・カメラ<br>
・幽霊が生存者に位置情報を伝える行為<br>
・待ち伏せ(クルーメイトのタスク勝利が不可能となる可能性があるため。)<br>

#### できないこと
・死体の通報<br>
・緊急会議ボタン<br>
・サボタージュ<br>

#### 設定

| 設定名 |
|----------|
| ドア閉鎖を許可する |
| インポスターの待機時間(秒) |
| 装飾品を禁止する |
| 通気口の使用を禁止する |

### NoGameEnd

#### クルーメイト陣営勝利条件
なし<br>

#### インポスター陣営勝利条件
なし<br>

#### 禁止事項
なし<br>

#### できないこと
ホストのSHIFT+L+Enter以外でのゲーム終了。<br>

勝利判定が存在しないデバッグ用のモードです。<br>

### RandomMapsMode/ランダムマップモード

ランダムにマップが変わるモードです。<br>

#### 設定

| 設定名 |
|----------|
| The Skeldを追加 |
| MIRA HQを追加 |
| Polusを追加 |
| The Airshipを追加 |

### SyncButtonMode/ボタン回数同期モード

プレイヤー全員のボタン回数が同期されているモードです。<br>

#### 設定

| 設定名 |
|----------|
| 合計ボタン使用可能回数 |

## OtherSettings/その他の設定

| 設定名 |
|----------|
| スキップ時 |
| 無投票時 |

#### クライアント設定
## HideCodes/コード隠し

有効化することで、ロビーコードを非表示にすることができます。

コンフィグファイル(BepInEx\config\com.emptybottle.townofhost.cfg)の``Hide Game Code Name``を書き換えることによって、HideCodesを有効にしたときに好きな文字を表示させることができます。
また、``Hide Game Code Color``を書き換えることによって文字の色も好きなように変更できます。

## JapaneseRoleName/役職名日本語化

有効化することで、役職名を日本語で表示させることができます。
クライアントの言語を英語にしている場合、ホストが``ForceJapanese``を有効にしていないとこの設定は意味のないものとなります。
## 参考など

[バウンティーハンター](###BountyHunter/バンティーハンター)や[マフィア](###Mafia/マフィア)、[ヴァンパイア](###Vampire/ヴァンパイア)、[魔女](###Witch/魔女)、[ベイト](###Bait/ベイト)、[メイヤー](###Mayor/メイヤー)、[シェリフ](###Sheriff/シェリフ)、[スニッチ](###Snitch/スニッチ)の役職とModの作成方法の参考 : https://github.com/Eisbison/TheOtherRoles<br>
[オポチュニスト](###Opportunist/オポチュニスト)の役職 : https://github.com/yukinogatari/TheOtherRoles-GM<br>
[ジェスター](###Jester/ジェスター)(てるてる)と[マッドメイト](###Madmate/マッドメイト)の役職 : https://au.libhalt.net<br>
[テロリスト](###Terrorist/テロリスト)(Trickstar + Joker) : https://github.com/MengTube/Foolers-Mod<br>

作者のTwitter : https://twitter.com/XenonBottle<br>
