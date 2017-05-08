<?php

namespace Mini\Model;

use Mini\Core\Model;

class Scores extends Model
{
    /**
     * Get all songs from database
     */
    public function getAllUsersSpacebar()
    {
        $sql = "SELECT Users.username, Users.country, Scores.score from Users join Scores on Users.ID = Scores.user_ID  WHERE Scores.game_ID = 1 ORDER BY Score DESC";
	    $query = $this->db->prepare($sql);
        $query->execute();
        return $query->fetchAll();
    }
    public function getAllUsersVillage()
    {
        $sql = "SELECT Users.username, Users.country, Scores.score from Users join Scores on Users.ID = Scores.user_ID  WHERE Scores.game_ID = 3 ORDER BY Score DESC";
	    $query = $this->db->prepare($sql);
        $query->execute();
        return $query->fetchAll();
    }
    public function getAllUsersTyping()
    {
        $sql = "SELECT Users.username, Users.country, Scores.score from Users join Scores on Users.ID = Scores.user_ID  WHERE Scores.game_ID = 2 ORDER BY Score DESC";
	    $query = $this->db->prepare($sql);
        $query->execute();
        return $query->fetchAll();
    }

    public function getUsersAndScore()
    {
        $sql = "SELECT Count(Users.username) from Users join Scores on Users.ID = Scores.user_ID  WHERE Scores.game_ID = 2 ORDER BY Score DESC";
        $query = $this->db->prepare($sql);
        $query->execute();

        // fetch() is the PDO method that get exactly one result
        return $query->fetch()->user_count;
    }
    public function getUsersAndScore2()
    {
        $sql = "SELECT COUNT(ID) AS user_count from Users";
        $query = $this->db->prepare($sql);
        $query->execute();

        // fetch() is the PDO method that get exactly one result
        return $query->fetch()->user_count;
    }
    public function getUsersAndScore3()
    {
        $sql = "SELECT COUNT(ID) AS user_count from Users";
        $query = $this->db->prepare($sql);
        $query->execute();

        // fetch() is the PDO method that get exactly one result
        return $query->fetch()->user_count;
    }
}
