/**
 * Storage Module for Form State Management
 * 
 * Provides utility functions for persisting and retrieving form state data
 * using the browser's sessionStorage API. SessionStorage automatically clears
 * when the browser tab is closed, making it ideal for temporary session data.
 * 
 * @module storage
 */

/**
 * Saves form state data to sessionStorage
 * 
 * Serializes the provided state object to JSON and stores it in sessionStorage
 * under the specified key. Logs the operation to console for debugging.
 * 
 * @param {string} key - The storage key under which to save the state
 * @param {Object} state - The form state object to save (will be JSON serialized)
 * @returns {boolean} True if the operation succeeded, false if an error occurred
 * 
 * @example
 * const formState = { date: '2024-01-15', name: 'John' };
 * saveFormState('myForm', formState);
 */
export function saveFormState(key, state) {
    try {
        sessionStorage.setItem(key, JSON.stringify(state));
        console.log('Form state saved to sessionStorage:', key, state);
        return true;
    } catch (error) {
        console.error('Error saving to sessionStorage:', error);
        return false;
    }
}

/**
 * Loads form state data from sessionStorage
 * 
 * Retrieves the JSON string from sessionStorage for the specified key.
 * Returns the raw JSON string (not parsed) to allow the calling code
 * to parse and validate the data according to its needs.
 * Logs the operation to console for debugging.
 * 
 * @param {string} key - The storage key under which the state is stored
 * @returns {string|null} The JSON string containing the form state, or null if not found or on error
 * 
 * @example
 * const stateJson = loadFormState('myForm');
 * if (stateJson) {
 *     const state = JSON.parse(stateJson);
 * }
 */
export function loadFormState(key) {
    try {
        const state = sessionStorage.getItem(key);
        console.log('Form state loaded from sessionStorage:', key, state);
        // Return the JSON string directly, not parsed
        return state;
    } catch (error) {
        console.error('Error loading from sessionStorage:', error);
        return null;
    }
}

/**
 * Clears form state data from sessionStorage
 * 
 * Removes the form state data stored under the specified key from sessionStorage.
 * Useful for clearing temporary data when the user completes a workflow or logs out.
 * Logs the operation to console for debugging.
 * 
 * @param {string} key - The storage key to remove
 * @returns {boolean} True if the operation succeeded, false if an error occurred
 * 
 * @example
 * clearFormState('myForm');
 */
export function clearFormState(key) {
    try {
        sessionStorage.removeItem(key);
        console.log('Form state cleared from sessionStorage:', key);
        return true;
    } catch (error) {
        console.error('Error clearing sessionStorage:', error);
        return false;
    }
}
