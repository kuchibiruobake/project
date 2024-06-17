<?php

require_once('mysql_connect.php');
$pdo = connectDB();

//POSTうけとり
$id = $_POST["id"]; //要求されてくるid

try {
    //今回ここではSELECT文を送信している。UPDATE、DELETEなどは、また少し記法が異なる。
    $stmt = $pdo->query("SELECT * FROM `unity` WHERE `id` = '". $id. "'");
    foreach ($stmt as $row) {
　　　　　//今回はただカラムを指定し、出力された文字列を結合して出力
        $res = $row['id'];
        $res = $res. $row['name'];
        $res = $res. $row['point'];
        $res = $res. $row['data'];
    }

} catch (PDOException $e) {
    var_dump($e->getMessage());
}
$pdo = null;    //DB切断

echo $res;  //unity に結果を返す
