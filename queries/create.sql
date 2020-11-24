-- abbreviation used:
-- u - user
-- g - group
-- n - note
-- m - message
-- s - sender
-- r - recipient
-- ud - displaying option for the user
-- un - notification option for the user

CREATE TABLE users
(
    u_id VARCHAR(8) NOT NULL,
    u_name VARCHAR(32) NOT NULL,
    u_surname VARCHAR(32),
    u_middlename VARCHAR(32),
    u_sex VARCHAR(1),
    u_birthdate DATE,
    u_country VARCHAR(32),
    u_city VARCHAR(32),
    u_phonenumber VARCHAR(14),
    u_avatar VARCHAR(12),
    u_description VARCHAR(256),
    u_password VARCHAR(256) NOT NULL,
    --displaying options
    ud_sex VARCHAR(1) NOT NULL,
    ud_birthdate VARCHAR(1) NOT NULL,
    ud_avatar VARCHAR(1) NOT NULL,
    ud_friends VARCHAR(1) NOT NULL,
    ud_groups VARCHAR(1) NOT NULL,
    ud_notes VARCHAR(1) NOT NULL,
    ud_messages VARCHAR(1) NOT NULL,
    --notifications settings
    un_notifications VARCHAR(1) NOT NULL,
    un_sounds VARCHAR(1) NOT NULL,
    un_content VARCHAR(1) NOT NULL,
    PRIMARY KEY(u_id)
);
CREATE TABLE friends
(
    u_id VARCHAR(8) NOT NULL,
    friend_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, friend_id)
);
CREATE TABLE outrequests
(
    u_id VARCHAR(8) NOT NULL,
    recipient_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, recipient_id)
);
CREATE TABLE inrequests
(
    u_id VARCHAR(8) NOT NULL,
    sender_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, sender_id)
);
CREATE TABLE id_classes
(
    id VARCHAR(8) NOT NULL,
    class VARCHAR(1) NOT NULL,
    PRIMARY KEY(id)
);
CREATE TABLE groups
(
    g_id VARCHAR(8) NOT NULL,
    g_name VARCHAR(32) NOT NULL,
    g_description VARCHAR(256),
    u_id VARCHAR(8) NOT NULL,
    g_avatar VARCHAR(12),
    PRIMARY KEY(g_id)
);
CREATE TABLE notes
(
    n_id VARCHAR(8) NOT NULL,
    id VARCHAR(8) NOT NULL,
    n_content VARCHAR(256),
    PRIMARY KEY(n_id)
);
CREATE TABLE n_docs
(
    n_id VARCHAR(8) NOT NULL,
    doc VARCHAR(12) NOT NULL,
    PRIMARY KEY(n_id, doc)
);
CREATE TABLE subs
(
    u_id VARCHAR(8) NOT NULL,
    g_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, g_id)
);
CREATE TABLE liked
(
    u_id VARCHAR(8) NOT NULL,
    n_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, n_id)
);
CREATE TABLE messages
(
    m_id VARCHAR(8) NOT NULL,
    s_id VARCHAR(8) NOT NULL,
    r_id VARCHAR(8) NOT NULL,
    m_content VARCHAR(256) NOT NULL,
    PRIMARY KEY(m_id)
);
CREATE TABLE m_docs
(
    m_id VARCHAR(8) NOT NULL,
    doc VARCHAR(12) NOT NULL,
    PRIMARY KEY(m_id, doc)
);