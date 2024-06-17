<?php
session_start();

$dsn = "mysql:host=127.0.0.1; dbname=typing; charset=utf8";
$username = "root";
$password = "";
$mail = $_POST['mail'];
$pass = $_POST['pass'];

try {
    $dbh = new PDO($dsn, $username, $password);
} catch (PDOException $e) {
    $msg = 'ログインできません';
    $link = '<a href="login_form.php">戻る</a>';
    show_message_and_exit($msg, $link);
}

$sql = "SELECT * FROM users WHERE mail = :mail";
$stmt = $dbh->prepare($sql);
$stmt->bindValue(':mail', $mail);
$stmt->execute();
$member = $stmt->fetch();

if ($member && password_verify($pass, $member['pass'])) {
    // DBのユーザー情報をセッションに保存
    $_SESSION['id'] = $member['id'];
    $_SESSION['name'] = $member['name'];
    header("Location: loading.html"); // ログインが成功したらindex.phpにリダイレクト
    exit();
} else {
    $msg = 'ログインできません';
    $link = '<a href="login_form.php">戻る</a>';
    show_message_and_exit($msg, $link);
}

function show_message_and_exit($msg, $link) {
    echo "<!DOCTYPE html>
    <html lang='ja'>
    <head>
        <meta charset='UTF-8'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>ログイン結果</title>
        <link rel='stylesheet' href='styles.css'>
    </head>
    <body>
        <div class='container'>
            <h1>{$msg}</h1>
            {$link}
        </div>
    </body>
    </html>";
    exit();
}
?>
