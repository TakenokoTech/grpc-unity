using System;

namespace Script.utils
{
    public static class TryExtension
    {
        /// <summary>
        /// エラーハンドリングを行い、<c>Promise&lt;T&gt;</c>を返却する。
        /// </summary>
        public static Promise<TR> RunCatching<T, TR>(this T self, TryBlock<T, TR> block)
        {
            try
            {
                return new Promise<TR>(block(self));
            }
            catch (Exception e)
            {
                return new Promise<TR>(e);
            }
        }
        
        public static Promise<bool> RunCatching<T>(this T self, TryBlockVoid<T> block)
        {
            try
            {
                block(self);
                return new Promise<bool>(true);
            }
            catch (Exception e)
            {
                return new Promise<bool>(e);
            }
        }
    }

    /// <summary>エラーハンドリング用のデリゲート</summary>
    public delegate TR TryBlock<in T, out TR>(T self);
    
    /// <summary>エラーハンドリング用のデリゲート</summary>
    public delegate void TryBlockVoid<in T>(T self);
}