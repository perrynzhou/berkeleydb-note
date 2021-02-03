/*-
 * Copyright (c) 1997, 2020 Oracle and/or its affiliates.  All rights reserved.
 *
 * See the file LICENSE for license information.
 *
 * $Id$
 */
package com.sleepycat.db;

import com.sleepycat.db.internal.DbEnv;

/**
Thrown if replication group was unable to elect a master, or was unable to
complete the election in the specified timeout period.
**/
public class ReplicationSiteUnavailableException extends DatabaseException {
    /* package */ ReplicationSiteUnavailableException(final String s,
                                   final int errno,
                                   final DbEnv dbenv) {
        super(s, errno, dbenv);
    }
}
