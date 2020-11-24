CREATE TABLE users
(
    id VARCHAR(8) NOT NULL,
    username VARCHAR(32) NOT NULL,
    usersurname VARCHAR(32),
    usermiddlename VARCHAR(32),
    sex VARCHAR(1),
    birthdate DATE,
    country VARCHAR(32),
    city VARCHAR(32),
    phonenumber VARCHAR(14),
    avatar VARCHAR(12),
    userdescription VARCHAR(256),
    userpassword VARCHAR(256) NOT NULL,
    --displaying options
    d_sex VARCHAR(1) NOT NULL,
    d_birthdate VARCHAR(1) NOT NULL,
    d_avatar VARCHAR(1) NOT NULL,
    d_friends VARCHAR(1) NOT NULL,
    d_groups VARCHAR(1) NOT NULL,
    d_notes VARCHAR(1) NOT NULL,
    d_messages VARCHAR(1) NOT NULL,
    --notifications settings
    notifications VARCHAR(1) NOT NULL,
    n_sounds VARCHAR(1) NOT NULL,
    n_content VARCHAR(1) NOT NULL,
    PRIMARY KEY(id)
);