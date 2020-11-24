CREATE TABLE groups
(
    id VARCHAR(8) NOT NULL,
    groupname VARCHAR(32) NOT NULL,
    master_id VARCHAR(8) NOT NULL,
    group_description VARCHAR(256),
    avatar VARCHAR(12),
    PRIMARY KEY(id)
);