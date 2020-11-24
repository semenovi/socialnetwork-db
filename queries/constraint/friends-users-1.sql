ALTER TABLE friends
ADD CONSTRAINT friends_fk1 FOREIGN KEY (friend_id) REFERENCES users (id)