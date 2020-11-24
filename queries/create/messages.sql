CREATE TABLE messages
(
    --m = message
    m_id VARCHAR(8) NOT NULL,
    --s = sender
    s_id VARCHAR(8) NOT NULL,
    --r = recipient
    r_id VARCHAR(8) NOT NULL,
    content VARCHAR(256) NOT NULL,
    PRIMARY KEY(m_id)
);