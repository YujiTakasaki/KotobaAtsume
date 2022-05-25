# 概要
メンターハッカソンで作成するゲームです。

# 構造
Scene について

- StartScene: 最初の簡単な会話(悪魔ちゃんが人間とお近づきになりたい！的なやつ)
- FieldScene: 野山を駆け巡って言葉を勉強する
- QuizScene: 人と実際に話す。

# 変数について
集めた言葉は、 `GameManager.cs` の `words` に static に宣言しています。
GameManager.cs を書き加えるのではなく、他のスクリプトから以下のようにして呼び出したり変更したりすることができます。
```C#
// 呼び出し
string hoge = GameManager.words[0];

// 追加
GameManager.words.add("あ");
