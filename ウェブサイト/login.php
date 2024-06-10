<?php
session_start();
$mail = $_POST['mail'];
$dsn = "mysql:host=127.0.0.1; dbname=typing; charset=utf8";
$username = "root";
$password = "";
try {
    $dbh = new PDO($dsn, $username, $password);
} catch (PDOException $e) {
    $msg = $e->getMessage();
}

$sql = "SELECT * FROM users WHERE mail = :mail";
$stmt = $dbh->prepare($sql);
$stmt->bindValue(':mail', $mail);
$stmt->execute();
$member = $stmt->fetch();
//指定したハッシュがパスワードにマッチしているかチェック
if (password_verify($_POST['pass'], $member['pass'])) {
    //DBのユーザー情報をセッションに保存
    $_SESSION['id'] = $member['id'];
    $_SESSION['name'] = $member['name'];
    $msg = 'ログインしました。';
    $link = '<a href="index.php" class="btn">ホーム</a>';
} else {
    $msg = 'メールアドレスもしくはパスワードが間違っています。';
    $link = '<a href="signup.php" class="btn">戻る</a>';
}
?>

<!DOCTYPE html>
<html lang="ja">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ログイン結果</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="result-container">
        <h1><?php echo $msg; ?></h1>
        <?php echo $link; ?>
    </div>
</body>
</html>
