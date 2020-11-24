CREATE TABLE subs
(
    --u = user
    u_id VARCHAR(8) NOT NULL,
    --g = group
    g_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, g_id)
);