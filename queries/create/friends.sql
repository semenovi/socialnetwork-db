CREATE TABLE friends
(
    id VARCHAR(8) NOT NULL,
    friend_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(id, friend_id)
);