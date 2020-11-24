ALTER TABLE users
ADD CONSTRAINT users_fk0
FOREIGN KEY (u_id)
REFERENCES id_classes (id);

ALTER TABLE friends
ADD CONSTRAINT friends_fk0
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE friends
ADD CONSTRAINT friends_fk1
FOREIGN KEY (friend_id)
REFERENCES users (u_id);

ALTER TABLE outrequests
ADD CONSTRAINT outrequests_fk0
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE outrequests
ADD CONSTRAINT outrequests_fk1
FOREIGN KEY (recipient_id)
REFERENCES users (u_id);

ALTER TABLE inrequests
ADD CONSTRAINT inrequests_fk0
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE inrequests
ADD CONSTRAINT inrequests_fk1
FOREIGN KEY (sender_id)
REFERENCES users (u_id);

ALTER TABLE groups
ADD CONSTRAINT groups_fk0
FOREIGN KEY (g_id)
REFERENCES id_classes (id);

ALTER TABLE groups
ADD CONSTRAINT groups_fk1
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE notes
ADD CONSTRAINT notes_fk0
FOREIGN KEY (n_id)
REFERENCES id_classes (id);

ALTER TABLE notes
ADD CONSTRAINT notes_fk1
FOREIGN KEY (id)
REFERENCES id_clases (id);

ALTER TABLE subs
ADD CONSTRAINT subs_fk0
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE subs
ADD CONSTRAINT subs_fk0
FOREIGN KEY (g_id)
REFERENCES groups (g_id);

ALTER TABLE liked
ADD CONSTRAINT liked_fk0
FOREIGN KEY (u_id)
REFERENCES users (u_id);

ALTER TABLE liked
ADD CONSTRAINT liked_fk1
FOREIGN KEY (n_id)
REFERENCES notes (n_id);

ALTER TABLE n_docs
ADD CONSTRAINT n_docs_fk0
FOREIGN KEY (n_id)
REFERENCES notes (n_id);

ALTER TABLE messages
ADD CONSTRAINT messages_fk0
FOREIGN KEY (s_id)
REFERENCES users (u_id);

ALTER TABLE messages
ADD CONSTRAINT messages_fk1
FOREIGN KEY (r_id)
REFERENCES users (u_id);

ALTER TABLE m_docs
ADD CONSTRAINT m_docs_fk0
FOREIGN KEY (m_id)
REFERENCES messages (m_id);